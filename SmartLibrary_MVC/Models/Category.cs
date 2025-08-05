namespace SmartLibrary_MVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}