using System.ComponentModel.DataAnnotations;

namespace Cake.Models
{
    public class ProductPreview : BaseEntity
    {
        [Required]
        public string Image { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
