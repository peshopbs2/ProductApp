using System.ComponentModel.DataAnnotations;

namespace ProductApp.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Title { get; set; }
        public virtual HashSet<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
