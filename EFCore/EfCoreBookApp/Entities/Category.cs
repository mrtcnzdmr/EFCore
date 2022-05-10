using System.Collections.Generic;

namespace EfCoreBookApp.Entities
{
    public class Category//Principal Entity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }//Collection Navigation Property
        


    }

}
