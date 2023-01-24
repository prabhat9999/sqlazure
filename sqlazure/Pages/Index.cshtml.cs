
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlazure.Models;
using sqlapp.Services;
namespace sqlazure.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;

        public void OnGet()
        {

        ProductService productService = new ProductService();
           Products= productService.GetProducts();
        }
    }
}