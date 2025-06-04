using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T4Ex23.Models;

namespace T4Ex23.Pages
{
    public class ProductsModel : PageModel
    {
        private static List<Product> _products = new();
        private static int _nextId = 1;

        [BindProperty]
        public Product NewProduct { get; set; } = new();

        public List<Product> Products => _products;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NewProduct.Id = _nextId++;
            _products.Add(NewProduct);

            NewProduct = new Product();

            return RedirectToPage();
        }
    }
}
