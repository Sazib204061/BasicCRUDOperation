using BasicCRUDOperation.Data;
using BasicCRUDOperation.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicCRUDOperation.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db)   //Receive the injected AppDbContext
        {
            _db = db;   //_dp ar modde sql connection store kore nilam and ata use kore database er data access korbo
        }
        public IActionResult Index()
        {
            List<Product> products = _db.Products.ToList();  //Get all the products from the database
            return View(products);   //send products list to index.cshtml file
        }
    }
}
