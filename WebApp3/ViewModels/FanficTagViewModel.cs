using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp3.Areas.Identity.DbContext;
using WebApp3.Interfaces;
using WebApp3.Models;

namespace WebApp3.ViewModels
{
    public class FanficTagViewModel
    {
        public IEnumerable<Fanfic> Fanfics { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<FanficTag> FanficsTags { get; set; }
        public IUnitOfWork IUnitOfWorkkk;

    }
}
