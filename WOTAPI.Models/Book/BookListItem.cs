using System.Collections.Generic;
using WOTAPI.Models.Chapter;

namespace WOTAPI.Models.Book
{
    public class BookListItem
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
    }
}
