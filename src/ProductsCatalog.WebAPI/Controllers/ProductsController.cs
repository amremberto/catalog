using Microsoft.AspNetCore.Mvc;
using ProductsCatalog.WebAPI.Entities;
using ProductsCatalog.WebAPI.Services;

namespace ProductsCatalog.WebAPI.Controllers;

[Route("api/[controller]")] // api/products
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(IProductService productService, ILogger<ProductsController> logger)
    {
        _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    //CRUD operations

    //GET api/products
    [HttpGet]
    public List<Product> Get()
    {
        _logger.LogInformation("Obtain all products");

        var result = _productService.GetProducts();

        return result;
    }

    //GET api/products/{id}
    [HttpGet("{id}")]
    public Product Get(Guid id)
    {
        var product = _productService.GetProduct(id);

        return product;
    }

    //POST api/products
    [HttpPost]
    public void Post(Product product)
    {
        _productService.AddProduct(product);
    }

    //PUT api/products/{id}
    [HttpPut("{id}")]
    public void Put(Guid id, Product updateProduct)
    {
        _productService.UpdateProduct(id, updateProduct);
    }

    //DELETE api/products/{id}
    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        _productService.DeleteProduct(id);
    }
}