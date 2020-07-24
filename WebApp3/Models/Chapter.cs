using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp3.Models
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public int FanficId { get; set; }
        public Fanfic Fanfics { get; set; }
        public string NameChapter { get; set; }
        public string TextChapter { get; set; }
        public int Like { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public DateTime DateTimePuplish { get; set; }
        [AllowNull]
        public string UlrImage { get; set; }
    }
}
