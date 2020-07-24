using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Models;
using WebApp3.ViewModels;

namespace WebApp3.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationUserDbContext _applicationUserDbContext;
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;
        private IWebHostEnvironment _webHostEnvironment;
        [BindProperty(SupportsGet = true)]
        public string SearchUser { get; set; }
        public HomeController(ILogger<HomeController> logger, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager,
            ApplicationUserDbContext applicationUserDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _applicationUserDbContext = applicationUserDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = _userManager.FindByEmailAsync(User.Identity.Name);

                if (user.Result.IsBlocked == true)
                {
                    return View("AccountBlockInformation");
                }
                return View();
            }

            return View();
        }
        [HttpGet]
        public IActionResult UsersList(string searchUser)
        {
            //var users = from m in _applicationUserDbContext.ApplicationUsers
            //    select m;

            IEnumerable<ApplicationUser> users = _applicationUserDbContext.ApplicationUsers.Include(p => p.Fanfics);
            if (!String.IsNullOrEmpty(searchUser))
            {
                users = users.Where(s => s.Email.Contains(searchUser));
            }
            return View(users);
        } 
        public IActionResult Login()
        {
            return Redirect("/Identity/Account/Login");
        }
        public async Task<IActionResult> Logout()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name); 
            user.IsActive = false;
          await   _userManager.UpdateAsync(user);
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Home");
        }

        public async Task<IActionResult> DeleteAccount()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            user.IsActive = false;
            await _userManager.UpdateAsync(user);
            IdentityResult result = await _userManager.DeleteAsync(user);
            return RedirectToAction("Logout", "Home");
        }

        public IActionResult MyInformation()
        {
            var username = _userManager.FindByEmailAsync(User.Identity.Name);
            IEnumerable<ApplicationUser> users = _applicationUserDbContext.ApplicationUsers.Include(p => p.Fanfics)
                .Where(n => n.Email == username.Result.Email)
                .ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                if (user != null)
                {
                    IdentityResult result = await _userManager.ChangePasswordAsync(user,
                        changePasswordViewModel.CurrentPassword, changePasswordViewModel.NewPassword);
                    if (result.Succeeded)
                    {
                        user.IsActive = false;
                        await _userManager.UpdateAsync(user);
                        await _signInManager.RefreshSignInAsync(user);
                        return View("ChangePasswordConfirmation");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }

                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(changePasswordViewModel);
            }
        }
        public async Task<IActionResult> BlockOrUnBlockAccount(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                if (user.IsBlocked == true)
                {
                    user.IsBlocked = false;
                   await _userManager.UpdateAsync(user);
                   return RedirectToAction("Logout","Home");
                }
                else
                {
                    user.IsBlocked = true;
                    user.IsActive = false;
                    await  _userManager.UpdateAsync(user);
                   return RedirectToAction("Logout", "Home");
                }
            }            
        }


        public IActionResult ViewFanfic()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ViewFanfic(ApplicationUserViewModel vm)
        {
            string stringFileName = UploadFile(vm);
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            user.ImageUrl = stringFileName;
            _applicationUserDbContext.ApplicationUsers.Update(user);
            _applicationUserDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        private string UploadFile(ApplicationUserViewModel vm)
        {
            string fileName = null;
            if (vm.ProfileImage != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                fileName = Guid.NewGuid().ToString() + '-' + vm.ProfileImage.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    vm.ProfileImage.CopyTo(fileStream);
                }
            }

            return fileName;
        }

        public string Privacy()
        {
            return "Hello!";
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
