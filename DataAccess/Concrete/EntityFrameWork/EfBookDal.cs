using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfBookDal : EfEntityRepositoryBase<Book, DatabaseContext>, IBookDal
    {

        public void Delete(Book bookId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Book bookToDelete = db.Books.SingleOrDefault(b => b.BookId == bookId.BookId);
                db.Books.Remove(bookToDelete);
                db.SaveChanges();
            }
        }

        public List<BookDetailDto> GetBookDetails()
        {
            /*using (DatabaseContext db = new DatabaseContext())
            {


                /*var result = from b in db.Books
                             join a in db.Authors
                             on b.AuthorId equals a.Id
                             select new BookDetailDto
                             {
                                 authorName = a.Name,
                                 authorSurname = a.Surname,
                                 bookID = b.BookId,
                                 bookName = b.Name,
                                 publisherName = 
                             }
            }*/

            throw new NotImplementedException();
        }

        public void Insert(Book book)
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                var ekle = book;
                db.Books.Add(new Book
                {
                    AuthorId = ekle.AuthorId,
                    BookId = ekle.BookId,
                    Date = ekle.Date,
                    Description = ekle.Description,
                    Language = ekle.Language,
                    Name = ekle.Name,
                    NumberofPage = ekle.NumberofPage,
                    PublisherId = ekle.PublisherId,
                    Shelf = ekle.Shelf
                });
                db.SaveChanges();
            }
        }
    }
}
