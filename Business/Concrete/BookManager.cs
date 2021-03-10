using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book book)
        {
            _bookDal.Insert(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetBookByAuthorId(int id)
        {
            return _bookDal.GetAll(book => book.AuthorId == id).ToList();
        }

        public List<Book> GetBookByPublisherId(int id)
        {
            return _bookDal.GetAll(pbls => pbls.PublisherId == id);
        }

        public List<BookDetailDto> GetBookDetails()
        {
            return _bookDal.GetBookDetails();
        }


        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
