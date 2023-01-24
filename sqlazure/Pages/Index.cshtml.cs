
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlazure.Models;
using sqlapp.Services;
namespace sqlazure.Pages
{
    public class IndexModel : PageModel
    {

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products;
        public void OnGet()
        {

       
           Products= _productService.GetProducts();
        }
    }
}