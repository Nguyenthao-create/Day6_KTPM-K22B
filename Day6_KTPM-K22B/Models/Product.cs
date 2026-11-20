using System.ComponentModel.DataAnnotations;

namespace Day6_KTPM_K22B.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string? Name { get; set; }
        [Range(0, 10000)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
