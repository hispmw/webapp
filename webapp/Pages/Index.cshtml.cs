using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.Models;
using webapp.Services;

namespace webapp.Pages;

public class IndexModel : PageModel
{
    //create a list object
    public List<Product> Products;


    
    public void OnGet()
    {
        //create a productService that will poplulate the list
        ProuctService productService = new ProuctService();
        Products = productService.GetProducts();


    }
}

