using ProductApp.Utility;
using System.ComponentModel.DataAnnotations;

namespace ProductApp.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [MinLength(3)]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Positive(ErrorMessage = "The price should be positive.")]
        public double Price { get; set; }
        public double Quantity { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; } //this is the big problem!
    }
}
