using ASP.NET_CA_SEVEN_SHOP.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CA_SEVEN_SHOP.Controllers
{
    public class LoginController : Controller
    {
        // Attributes
        private readonly AppDbContext _db;
        private readonly ILogger<LoginController> _logger;
        // Constructor
        public LoginController(ILogger<LoginController> logger, AppDbContext db)
        {
            _db = db;
            _logger = logger ;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("CustomerId") != null)
            {
                return RedirectToAction("", "Home");
            }

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("", "Login");
        }


        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var user = _db.Customers.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("CustomerId", user.CustomerId.ToString());
                HttpContext.Session.SetString("Username", user.Username);
                return RedirectToAction("Purchases", "Home");
            }
            else
            {
                ViewBag.ErrorMsg = "Invalid username or password";
                return View();
            }
        }
    }
}
