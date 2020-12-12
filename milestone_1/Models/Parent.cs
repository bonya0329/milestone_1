using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace milestone_1.Models
{
    public class Parent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        [OnlyStringAttribute]
        public string Name { get; set; }
       
        [Required]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        [OnlyStringAttribute]
        public string SurName { get; set; }

        [Required]
        [OnlyNumbersAttribute]
        public string TelNumber { get; set; }

        //Validation of string
        public class OnlyStringAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value != null)
                {
                    String stringValue = value.ToString();
                    if (stringValue.Any(char.IsDigit) == false)
                        return ValidationResult.Success;
                }

                return new ValidationResult("Only letters please");
            }
        }
        //Validation of Age
        public class OnlyNumbersAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value != null)
                {
                    int result;
                    String stringValue = value.ToString();
                    if (int.TryParse(stringValue, out result))
                        return ValidationResult.Success;
                }

                return new ValidationResult("Only numbers");
            }
        }
    }
}