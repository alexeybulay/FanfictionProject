using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Areas.Identity.Pages.Account;
using WebApp3.Models;

namespace WebApp3.Views.Home
{
    public class AddFanficModel : PageModel
    {
        //private readonly UserManager<Fanfic> _fanficManager;
        //private readonly UserManager<ApplicationUser> _userManager;

        //public AddFanficModel(
        //    UserManager<ApplicationUser> userManager, UserManager<Fanfic> fanficManager)
        //{
        //    _userManager = userManager;
        //    _fanficManager = fanficManager;
        //}

        //[BindProperty] public InputModel Input { get; set; }
        //public string ReturnUrl { get; set; }
        //public IList<AuthenticationScheme> ExternalLogins { get; set; }


        //public class InputModel
        //{
        //    [Required]
        //    [DataType(DataType.Text)]
        //    [Display(Name = "Name Fanfic")]
        //    public string NameFanfic { get; set; }

        //    [Required]
        //    [DataType(DataType.Text)]
        //    [Display(Name = "Description")]
        //    public string Description { get; set; }
        //}

        //public void OnGetAsync(string returnUrl = null)
        //{
        //    ReturnUrl = returnUrl;
        //}

        //public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        //{
        //    returnUrl = returnUrl ?? Url.Content("~/");
        //    if (ModelState.IsValid)
        //    {
        //        //var user = await _userManager.FindByEmailAsync(User.Identity.Name);
        //        var inputFanfic = new Fanfic
        //        {
        //            NameFanfic = Input.NameFanfic, Description = Input.Description
        //        };
        //        var fanfic = await _fanficManager.CreateAsync(inputFanfic);
        //        if (fanfic.Succeeded)
        //        {
        //            inputFanfic.DateTimePublish = DateTime.Now;
        //            await _fanficManager.UpdateAsync(inputFanfic);
        //        }

        //        foreach (var error in fanfic.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //    }

        //    return Page();
        //}

    }
}
