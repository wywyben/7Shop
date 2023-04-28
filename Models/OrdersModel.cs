using System.ComponentModel.DataAnnotations;

namespace ASP.NET_CA_SEVEN_SHOP.Models
{
    public class OrdersModel
    {
        public OrdersModel()
        {
            //CreateAt = DateTime.Now;
        }

        // Auto-Properties
        [Key]
        public int OrderId { get; set; }

        [Required]

        public int CustomerId { get; set; }
        [Required]
        public string? ProductName { get; set; }

        [Required]
        public double? ProductPrice { get; set; }

        

        [Required]
        public double? ProductQuantity { get; set; }
        [Required]
        public string? ProductDate { get; set;}
    }
}
