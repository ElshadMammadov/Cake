using System.ComponentModel.DataAnnotations;

namespace Cake.Models
{
    public class Product :BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Image { get; set; }
        public string Description { get; set; }          
        public string StockCode { get; set; }            
        public string Tags { get; set; }               
        public string AdditionalInformation { get; set; } 
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductPreview> Previews { get; set; }
    }
}

