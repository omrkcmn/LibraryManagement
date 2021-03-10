using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
        List<Book> GetBookByAuthorId(int id);
        List<Book> GetBookByPublisherId(int id);
        List<BookDetailDto> GetBookDetails();
    }
}
