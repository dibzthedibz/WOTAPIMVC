using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTAPI.Models.Book
{
    public class BookListItem
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
    }
}
