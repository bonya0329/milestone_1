using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace milestone_1.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
