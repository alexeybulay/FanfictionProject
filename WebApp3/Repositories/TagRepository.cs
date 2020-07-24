using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Interfaces;
using WebApp3.Models;

namespace WebApp3.Repositories
{
    public class TagRepository : ITag
    {
        private readonly ApplicationUserDbContext _applicationUserDbContext;

        public TagRepository(ApplicationUserDbContext applicationUserDbContext)
        {
            _applicationUserDbContext = applicationUserDbContext;
        }

        public List<Tag> GetAll()
        {
            return _applicationUserDbContext.Tags.ToList();
        }

        public Tag GetById(int Id)
        {
            return _applicationUserDbContext.Tags.FirstOrDefault(x => x.TagId == Id);
        }

        public void Insert(Tag tag)
        {
            _applicationUserDbContext.Tags.Add(tag);
        }

        public void Update(Tag tag)
        {
            _applicationUserDbContext.Tags.Update(tag);
        }

        public void Delete(Tag tag)
        {
            _applicationUserDbContext.Tags.Remove(tag);
        }
    }
}
