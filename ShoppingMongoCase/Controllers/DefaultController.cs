using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongoCase.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
