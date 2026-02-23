using System.ComponentModel.DataAnnotations;
namespace Cake.Models
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        public string? IconClass { get; set; }
        public List<Product> Products { get; set; }
    }
}
