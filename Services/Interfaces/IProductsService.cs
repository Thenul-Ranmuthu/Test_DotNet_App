
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Interfaces;

public interface IProductsService
{
    Task<ActionResult<List<Product>>> GetAllProducts();
    Task<Product?> GetOneProduct(int id);
}