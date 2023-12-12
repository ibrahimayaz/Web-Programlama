using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDbContext _context;
        public ProductController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //SELECT * FROM Product
            return View(_context.Product.ToList());
        }
    }
}
