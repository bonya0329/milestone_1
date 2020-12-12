using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace milestone_1.Models
{
    public class Student : IValidatableObject
    {
        public int StudentID { get; set; }
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
        public int Age { get; set; }

        public virtual Parent Parent { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (this.Age < 1 || this.Age > 150)
                errors.Add(new ValidationResult("Invalid age"));

            return errors;
        }

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
