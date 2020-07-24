using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp3.Models;

namespace WebApp3.Interfaces
{
    public interface IFanfic
    {
        List<Fanfic> GetAll();
        IEnumerable<Fanfic> GetMyFanfics(string Id);
        void Insert(Fanfic fanfic);
        void Update(Fanfic fanfic);
        void Delete(Fanfic fanfic);
    }
}
