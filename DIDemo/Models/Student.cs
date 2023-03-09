using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIDemo.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Rollno { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Stream { get; set; }
        [Required]
        public decimal Percentage { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string? Gender { get; set; }

    }
}
