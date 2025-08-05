using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLibrary_MVC.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        [Range(3, 10, ErrorMessage = "Minimum 3 and Max 10 books can be added")]
        public int QtyAvailable { get; set; } = 5;

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

    }
}