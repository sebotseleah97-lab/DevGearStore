using Microsoft.AspNetCore.Mvc.RazorPages;
using DevGearStore.Models;
using DevGearStore.Services;

public class ProductsModel : PageModel
{
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        Products = ProductService.Products;
    }
}
