using System.ComponentModel.DataAnnotations;
namespace SmartLibrary_MVC.Validations
{
    public class CategoryCodeValidate : ValidationAttribute
    {
        public CategoryCodeValidate() { }
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value == null)
            {
                return new ValidationResult(ErrorMessage = "Category Code is required");
            }
            if (string.IsNullOrEmpty(value.ToString()))
            {
                return new ValidationResult(ErrorMessage = "Category Code cannot be empty");
            }
            if (value.ToString().StartsWith("CAT-"))
            {
                return new ValidationResult(ErrorMessage = "Category Code must start with 'CAT-'");

            }
                return ValidationResult.Success;   
        }
    }
}