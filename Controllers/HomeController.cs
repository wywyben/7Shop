using ASP.NET_CA_SEVEN_SHOP.Data;
using ASP.NET_CA_SEVEN_SHOP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace ASP.NET_CA_SEVEN_SHOP.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index(string searchStr)
        {
            var products =  Mock_Data.GetProductData();

            // Filter the products list based on the searchStr query string parameter
            if (!string.IsNullOrEmpty(searchStr))
            {
                products = products.Where(p =>
                p.Title!.ToLower().Contains(searchStr.ToLower()) ||
                p.Rating!.ToLower().Contains(searchStr.ToLower()) ||
                p.Category!.ToLower().Contains(searchStr.ToLower()) ||
                p.Description!.ToLower().Contains(searchStr.ToLower())

                ).ToList();
            }

            //ViewBag.products = products;

            return View(products);
            //return View();
        }
        public IActionResult DetailedSearch(string searchStr)
        {
            var products = Mock_Data.GetProductData();

            // Filter the products list based on the searchStr query string parameter
            if (!string.IsNullOrEmpty(searchStr))
            {
                products = products.Where(p =>
                p.Title!.ToLower().Contains(searchStr.ToLower()) ||
                p.Rating!.ToLower().Contains(searchStr.ToLower()) ||
                p.Category!.ToLower().Contains(searchStr.ToLower()) ||
                p.Description!.ToLower().Contains(searchStr.ToLower())

                ).ToList();
            }

            return View("Index", products);
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Purchases()
        {
            if (HttpContext.Session.GetString("CustomerId") == null)
            {
                return RedirectToAction("", "Login");
            }

            var products = _db.Orders.ToList();
            return View(products);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}