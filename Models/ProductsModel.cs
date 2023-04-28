using System.ComponentModel.DataAnnotations;

namespace ASP.NET_CA_SEVEN_SHOP.Models
{
    public class ProductsModel
    {
        // Constructor
        public ProductsModel()
        {
            //CreateAt = DateTime.Now;
        }

        // Auto-Properties
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        public string? ProductDescription { get; set; }

        //[Required]
       // public double ProductPrice { get; set; }

        [Required]
        public string? ProductImageUrl { get; set; }

        //public double ProductReview { get; set; }

        //public string ProductQuantity { get; set; }

        //public DateTime CreateAt { get; set; }
    }
}