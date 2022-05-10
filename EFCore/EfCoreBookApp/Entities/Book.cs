using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBookApp.Entities
{
    public class Book//Dependent Entity(Category'e bağımlı)
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }//Foreign Key
        public Category Category { get; set; } //Simple Navigation Property
       
        public BookDetail BookDetail { get; set; }//Navigation Property

        //Collection Navigation Property
        public ICollection<BookAuthor> BookAuthors { get; set; }

    }

}
