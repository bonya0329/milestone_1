using System.ComponentModel.DataAnnotations;

namespace milestone_1.Models
{
    public class Parent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        public string Name { get; set; }
       
        [Required]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        public string SurName { get; set; }

        public string TelNumber { get; set; }
    }
}