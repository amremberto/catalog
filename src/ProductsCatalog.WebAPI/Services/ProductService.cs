using ProductsCatalog.WebAPI.Entities;

namespace ProductsCatalog.WebAPI.Services;

public class ProductService : IProductService
{
    private static List<Product> products = new List<Product>
    {
        new Product { Id = Guid.NewGuid(), Name = "Product 1", Description = "Description 1", Price = 10.5m },
        new Product { Id = Guid.NewGuid(), Name = "Product 2", Description = "Description 2", Price = 20.5m },
        new Product { Id = Guid.NewGuid(), Name = "Product 3", Description = "Description 3", Price = 30.5m }
    };

    public List<Product> GetProducts()
    {
        return products;
    }
    public Product GetProduct(Guid id)
    {
        var product = products.Find(p => p.Id == id);

        if (product is null)
        {
            var result = new Product();
            return result;
        }
        return product;
    }
    public void AddProduct(Product product)
    {
        product.Id = Guid.NewGuid();

        products.Add(product);
    }
    public void UpdateProduct(Guid id, Product updateProduct)
    {
        var product = products.Find(p => p.Id == id);

        if (product is not null)
        {
            product.Name = updateProduct.Name;
            product.Description = updateProduct.Description;
            product.Price = updateProduct.Price;
        }
    }
    public void DeleteProduct(Guid id)
    {
        var product = products.Find(p => p.Id == id);
        if (product is not null)
        {
            products.Remove(product);
        }
    }
}
