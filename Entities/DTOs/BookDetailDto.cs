using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BookDetailDto : IEntityBook
    {
        public int bookID { get; set; }
        public string authorName { get; set; }
        public string authorSurname { get; set; }
        public string bookName { get; set; }
        public string publisherName { get; set; }
        public string shelfLocation { get; set; }
    }
}
