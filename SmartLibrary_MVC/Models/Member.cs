using System.ComponentModel.DataAnnotations;

namespace SmartLibrary_MVC.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Required]
        public string MemberName { get; set; }
        [Required(ErrorMessage = " Member Email is required")]
        [EmailAddress(ErrorMessage = "Member Email is not in proper format ")]
        public string MemberEmail { get; set; }

        [RegularExpression("^[0-9]{3}-[0-9]{3}$",
            ErrorMessage = "Author Phone number must be in the format xxx-xxx-xxxx")]
        public string MemberPhone { get; set; }
        [DataType(DataType.Date)]
        public DateOnly MemberJoiningDate { get; set; }
    }
}