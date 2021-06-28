using System;
using System.Collections.Generic;
using System.Linq;
using WOTAPI.Data;
using WOTAPI.Models.Book;
using WOTAPI.Models.Chapter;

namespace WOTAPI.Services
{
    public class BookService
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

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

        public BookDetail GetBookDetail(int bookId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Books
                    .Single(e => e.BookId == bookId);
                return
                    new BookDetail
                    {
                        BookId = bookId,
                        Title = entity.Title,
                        PageCount = entity.PageCount,
                        Chapters = entity.Chapters
                        .Select(e => new ChapterListItem()
                        {
                            ChapNum = e.ChapNum,
                            ChapTitle = e.ChapTitle,
                            PageCount = e.PageCount
                        }).ToList()
                    };
            }
        }
        public List<ChapterListItem> CreateChapterList(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Chapters
                    .Where(e => e.BookId == id)
                    .Select(e => new ChapterListItem()
                    {
                        ChapNum = e.ChapNum,
                        ChapTitle = e.ChapTitle,
                        PageCount = e.PageCount
                    }).ToList();
                var chapterList = entity;
                return chapterList;
            }
        }
    }
}
