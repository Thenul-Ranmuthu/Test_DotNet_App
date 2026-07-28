using API.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProductsService productsService) : ControllerBase
    {
        [HttpGet()]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            // return await context.Products.ToListAsync();
            return await productsService.GetAllProducts();
        }

        [HttpGet("{id}")]
        async public Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await productsService.GetOneProduct(id);
            if(product == null) return NotFound();

            return product;
        }
    }
}