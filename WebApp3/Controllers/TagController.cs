using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Interfaces;
using WebApp3.Models;
using WebApp3.ViewModels;

namespace WebApp3.Controllers
{
    public class TagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private ApplicationUserDbContext _applicationUserDbContext;

        private IMapper _mapper;
        public TagController(IUnitOfWork unitOfWork, IMapper mapper, ApplicationUserDbContext applicationUserDbContext)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _applicationUserDbContext = applicationUserDbContext;
        }
        // GET: TagController
        public async Task<ActionResult> TagList(string searchTags)
        {
            
            //var model = _unitOfWork.Tag.GetAll();
            //var viewmodel = _mapper.Map<List<TagViewModel>>(model);
            //var users = from m in _applicationUserDbContext.Tags
            //    select m;

            if (!String.IsNullOrEmpty(searchTags))
            {
                return View(new FanficTagViewModel()
                {
                    Tags = await _applicationUserDbContext.Tags.Where(n => n.TagTitle.Contains(searchTags)).ToArrayAsync()
                });
            }

            return View(new FanficTagViewModel()
            {
                Tags = await _applicationUserDbContext.Tags.Include(p => p.FanficsTags)
                    .ThenInclude(t => t.Fanfic).ToArrayAsync()
            });
        }

        // GET: TagController/Details/5
     

        // GET: TagController/Create
        public ActionResult CreateTag()
        {
            return View();
        }

        // POST: TagController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTag(CreateTagViewModel createTagViewModel)
        {
            try
            {
                var model = _mapper.Map<Tag>(createTagViewModel);
                  _unitOfWork.Tag.Insert(model);
                  _unitOfWork.Save();
                return RedirectToAction("TagList", "Tag");
            }
            catch
            {
                return View();
            }
        }

        // GET: TagController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TagController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TagController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TagController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
