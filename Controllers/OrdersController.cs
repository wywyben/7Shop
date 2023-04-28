
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NET_CA_SEVEN_SHOP.Models;
using ASP.NET_CA_SEVEN_SHOP.Data;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_CA_SEVEN_SHOP.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext db;
        

        public OrdersController(ApplicationDbContext context)
        {
            db = context;
            
        }

        public IActionResult Index()
        {
            var products = db.Products.ToList();
            return View(products);

        }

       
    }
}
