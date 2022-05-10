namespace EfCoreBookApp.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }

        public int BookId { get; set; }//Foreign Key-Unique
        public string ISSN { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public Book Book { get; set; }//Navigation Property

    }

}
