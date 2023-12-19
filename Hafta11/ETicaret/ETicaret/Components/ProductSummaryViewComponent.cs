using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Components
{
    [ViewComponent(Name ="UrunOzeti")]
    public class ProductSummaryViewComponent: ViewComponent
    {
        private readonly MyDbContext _context;
        public ProductSummaryViewComponent(MyDbContext context)
        {
            _context = context;
        }

        public string Invoke() => _context.Product.Count().ToString();
    }
}
