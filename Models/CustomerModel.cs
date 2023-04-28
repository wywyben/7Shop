using System.ComponentModel.DataAnnotations;

namespace ASP.NET_CA_SEVEN_SHOP.Models
{
    public class CustomerModel
    {
        // Constructor
        public CustomerModel()
        {
            CreateAt = DateTime.Now;
        }

        // Auto-Properties
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime CreateAt { get; set; }
    }
}