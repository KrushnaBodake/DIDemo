using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIDemo.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id{ get; set; }
        [Required]
        public string? Pname { get; set; }
        [Required]
        public string? Company { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
