using Microsoft.AspNetCore.Mvc;
using ProductsCatalog.WebAPI.Entities;

namespace ProductsCatalog.WebAPI.Controllers;

[Route("api/[controller]")] // api/products
[ApiController]
public class ProductsController : ControllerBase
{
    //CRUD operations

    //GET api/products
    [HttpGet]
    public List<Product> Get()
    {
        var products = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Product 1", Description = "Description 1", Price = 10.5m },
            new Product { Id = Guid.NewGuid(), Name = "Product 2", Description = "Description 2", Price = 20.5m },
            new Product { Id = Guid.NewGuid(), Name = "Product 3", Description = "Description 3", Price = 30.5m }
        };

        return products;
    }
}
