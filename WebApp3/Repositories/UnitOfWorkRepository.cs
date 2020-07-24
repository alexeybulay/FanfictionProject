using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Interfaces;
using WebApp3.Models;

namespace WebApp3.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly ApplicationUserDbContext _applicationUserDbContext;
        public IEnumerable<Fanfic> _fanficList;
        private IFanfic _fanficRepository;
        private ITag _tagRepository;

        public UnitOfWorkRepository(ApplicationUserDbContext applicationUserDbContext, IEnumerable<Fanfic> fanficList)
        {
            _applicationUserDbContext = applicationUserDbContext;
            _fanficList = fanficList;
        }
        public IFanfic Fanfic { get => _fanficRepository = _fanficRepository ?? new FanficRepository(_applicationUserDbContext, _fanficList);  }
        public ITag Tag { get => _tagRepository = _tagRepository ?? new TagRepository(_applicationUserDbContext); }
        public void Save()
        {
            _applicationUserDbContext.SaveChanges();
        }
    }
}
