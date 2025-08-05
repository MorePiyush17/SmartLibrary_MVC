using System.ComponentModel.DataAnnotations;

namespace SmartLibrary_MVC.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = " Author Email is required")]
        [EmailAddress(ErrorMessage = "Author Email is not in proper format ")]
        public string AuthorEmail { get; set; }
        [RegularExpression("^[0-9]{3}-[0-9]{3}$",
            ErrorMessage = "Author Phone number must be in the format xxx-xxx-xxxx")]
        public string AuthorPhone { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}