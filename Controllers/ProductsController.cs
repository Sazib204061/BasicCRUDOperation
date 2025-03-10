using Microsoft.AspNetCore.Mvc;

namespace BasicCRUDOperation.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
