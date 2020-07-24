using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp3.Models;

namespace WebApp3.Interfaces
{
    public interface ITag
    {
        List<Tag> GetAll();
        Tag GetById(int Id);
        void Insert(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
    }
}
