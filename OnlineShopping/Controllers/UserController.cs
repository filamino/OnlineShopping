using Microsoft.AspNetCore.Mvc;

namespace OnlineShopping.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
