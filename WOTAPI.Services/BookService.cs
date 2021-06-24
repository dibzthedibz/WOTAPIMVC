using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTAPI.Data;
using WOTAPI.Models.Book;
using WOTAPI.WebMVC.Models;

namespace WOTAPI.Services
{
    public class BookService
    {
        public bool CreateBook(BookCreate book)
        {
            var entity = new Book()
            {
                Title = book.Title,
                PageCount = book.PageCount
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Books.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //public IEnumerable<BookListItem> GetBooks()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query = ctx.Books.Where(e =>);
        //    }
        //}
    }
}
