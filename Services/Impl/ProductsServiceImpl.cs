using API.Data;
using API.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Impl;

public class ProductsServiceImpl(StoreContext context) : IProductsService
{
    async Task<ActionResult<List<Product>>> IProductsService.GetAllProducts()
    {
       return await context.Products.ToListAsync();
    }

    async Task<Product?> IProductsService.GetOneProduct(int id)
    {
        return await context.Products.FindAsync(id);

    }
}