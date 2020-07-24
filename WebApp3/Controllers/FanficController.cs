using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Interfaces;
using WebApp3.Models;
using WebApp3.ViewModels;

namespace WebApp3.Controllers
{
    public class FanficController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private IMapper _mapper;
        private UserManager<ApplicationUser> _userManager;
        private ApplicationUserDbContext _a;
        public FanficController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<ApplicationUser> userManager, ApplicationUserDbContext a)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _a = a;
        }
        // GET: FanficController
        public async Task<ActionResult> FanficList(string searchUser, int id = 0)
        {
            var user = _userManager.GetUserId(HttpContext.User);
            var fanfics = _unitOfWork.Fanfic.GetMyFanfics(user);
            var viewmodel = _mapper.Map<List<FanficViewModel>>(fanfics);
            if (!string.IsNullOrEmpty(searchUser))
            {
                return View(new FanficTagViewModel()
                {
                    FanficsTags = await _a.FanficsTags.Include(p => p.Fanfic)
                        .Include(n => n.Tag).Where(res => res.Fanfic.NameFanfic.Contains(searchUser)).ToListAsync(),
                });
            }

            if (id != 0)
            {
                return View(new FanficTagViewModel()
                {
                    FanficsTags = await _a.FanficsTags.Include(n => n.Fanfic)
                        .Include(n => n.Tag)
                        .Where(n => n.TagId == id)
                        .ToListAsync()
                });
            }

            return View(new FanficTagViewModel()
            {
                FanficsTags = await _a.FanficsTags.Include(n => n.Fanfic)
                    .Include(n => n.Tag)
                    .ToListAsync()
            });
        }

        // GET: FanficController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FanficController/Create
        public ActionResult CreateFanfic()
        {
            if (User.Identity.IsAuthenticated)
            {
                var tagsFromRepo = _unitOfWork.Tag.GetAll();
                var selectList = new List<SelectListItem>();
                foreach (var tags in tagsFromRepo)
                {
                    selectList.Add(new SelectListItem(tags.TagTitle, tags.TagId.ToString()));
                }

                var vm = new CreateFanficViewModel()
                {
                    Tags = selectList
                };
                return View(vm);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // POST: FanficController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateFanfic(CreateFanficViewModel createFanficViewModel)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                var model = _mapper.Map<Fanfic>(createFanficViewModel);
                model.ApplicationUser = user;
                foreach (var tags in createFanficViewModel.SelectedTags)
                {
                   model.FanficsTags.Add(new FanficTag()
                   {
                       TagId = Int32.Parse(tags)

                   }); 
                }
                _unitOfWork.Fanfic.Insert(model);
                _unitOfWork.Save();
                return RedirectToAction("FanficList", "Fanfic");
            }
            catch
            {
                return View();
            }
        }

        // GET: FanficController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FanficController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(FanficList));
            }
            catch
            {
                return View();
            }
        }

        // GET: FanficController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FanficController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(FanficList));
            }
            catch
            {
                return View();
            }
        }
    }
}
