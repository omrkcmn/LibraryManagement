using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book : IEntityBook
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string Shelf { get; set; }
        public string Date { get; set; }
        public string Name{ get; set; }
        public int NumberofPage { get; set; }
    }
}
