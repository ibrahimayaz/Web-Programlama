using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Components
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly MyDbContext _context;
        public CategoryListViewComponent(MyDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Category.ToList());
        }
    }
}
