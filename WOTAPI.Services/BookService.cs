using System;
using System.Collections.Generic;
using System.Linq;
using WOTAPI.Data;
using WOTAPI.Models.Book;

namespace WOTAPI.Services
{
    public class BookService
    {
        private readonly Guid _userId;
        public BookService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateBook(BookCreate model)
        {
            var entity = new Book()
            {
                OwnerId = _userId,
                Title = model.Title,
                PageCount = model.PageCount
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Books.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<BookListItem> GetBooks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Books.Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new BookListItem
                        {
                            BookId = e.BookId,
                            Title = e.Title,
                            PageCount = e.PageCount
                        }
                    );
                return query.ToArray();
            }
        }
    }
}
