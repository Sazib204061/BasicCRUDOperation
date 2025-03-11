using BasicCRUDOperation.Data;
using BasicCRUDOperation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUDOperation.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db)   //Receive the injected AppDbContext
        {
            _db = db;   //_dp ar modde sql connection store kore nilam and ata use kore database er data access korbo
        }

        /*
        public IActionResult Index()
        {
            List<Product> products = _db.Products.ToList();  //Get all the products from the database
            return View(products);   //send products list to index.cshtml file
        }
        */
        //using asynchronous programming
        public async Task<IActionResult> Index()
        {
            var products = await _db.Products.ToListAsync(); // Fetch all products
            return View(products);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)      //for field validation
            {
                await _db.Products.AddAsync(product);  //Asynchronusly add all data to Products table
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");  //here we stay same controller that's why does not need to specify controller name
                                                   //return RedirectToAction("Action_Name", "Controller_Name");
            }
            return View("Create");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound(id);
            }

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            _db.Update(product);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //for deletion
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (product == null) 
            {
                return NotFound(id);
            }

            _db.Products.Remove(product);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
