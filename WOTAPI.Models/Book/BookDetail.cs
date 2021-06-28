using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTAPI.Models.Chapter;

namespace WOTAPI.Models.Book
{
    public class BookDetail
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public virtual List<ChapterListItem> Chapters { get; set; }
    }
}
