using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Interfaces;
using WebApp3.Models;

namespace WebApp3.Repositories
{
    public class FanficRepository : IFanfic
    {
        public IEnumerable<Fanfic> _fanficList;
        private readonly ApplicationUserDbContext _applicationUserDbContext;

        public FanficRepository(ApplicationUserDbContext applicationUserDbContext, IEnumerable<Fanfic> fanficList)
        {
            _applicationUserDbContext = applicationUserDbContext;
            _fanficList = fanficList;
        }
        public List<Fanfic> GetAll()
        {
            return _applicationUserDbContext.Fanfics.ToList();
        }

        public IEnumerable<Fanfic> GetMyFanfics(string Id)
        {
            return _applicationUserDbContext.Fanfics.Include(p => p.ApplicationUser).ToList().Where(i => i.ApplicationUserId == Id);
        }

        public Fanfic GetById(int Id)
        {
            return _applicationUserDbContext.Fanfics.FirstOrDefault(x => x.FanficId == Id);
        }

        public void Insert(Fanfic fanfic)
        {
            _applicationUserDbContext.Fanfics.Add(fanfic);
        }

        public void Update(Fanfic fanfic)
        {
            _applicationUserDbContext.Fanfics.Update(fanfic);
        }

        public void Delete(Fanfic fanfic)
        {
            _applicationUserDbContext.Fanfics.Remove(fanfic);
        }
    }
}
