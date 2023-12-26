using ETicaret.Areas.Admin.Models;
using ETicaret.Models;
using ETicaret.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ETicaret.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        private readonly MyDbContext _context;

        public ProductController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            ProductVM pVM = new ProductVM();
            pVM.CategoryList= _context.Category
                          .Select(a => new SelectListItem()
                          {
                              Value = a.Id.ToString(),
                              Text = a.Name
                          }).ToList();
            return View(pVM);
        }


        [HttpPost]
        public IActionResult Add(ProductVM p)
        {
            Product p1 = new Product()
            {
                Id = 0,
                CategoryId = p.CategoryId,
                Name = p.Name,
                Description = p.Description,
                Quantity = p.Quantity
            };

            _context.Product.Add(p1);
            _context.SaveChanges();
            return View("List", _context.Product.ToList());
        }



        public IActionResult Update(int id)
        {
            ProductVM pVM = new ProductVM();
            var model=_context.Product.FirstOrDefault(a => a.Id == id);
            pVM.Id = model.Id;
            pVM.Name = model.Name;
            pVM.Description = model.Description;
            pVM.Quantity = model.Quantity;
            pVM.CategoryId=model.CategoryId; 
            pVM.CategoryList = _context.Category
                          .Select(a => new SelectListItem()
                          {
                              Value = a.Id.ToString(),
                              Text = a.Name
                          }).ToList();
            return View(pVM);
        }



        [HttpPost]
        public IActionResult Update(ProductVM p)
        {
            var model = _context.Product.FirstOrDefault(a => a.Id == p.Id);
            if (model!=null)
            {
                model.Name = p.Name;
                model.Description = p.Description;
                model.Quantity=p.Quantity;
                model.CategoryId=p.CategoryId;
                _context.SaveChanges();
            }

            return View("List", _context.Product.ToList());
        }


        public IActionResult List()
        {
            var model = _context.Product.ToList();
            return View(model);
        }

    }
}
