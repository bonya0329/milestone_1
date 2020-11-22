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

        public string Name { get; set; }
        [Required]
        
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        public string SurName { get; set; }
        [Required]
       
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
    }
}
