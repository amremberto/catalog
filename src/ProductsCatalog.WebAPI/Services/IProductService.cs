using ProductsCatalog.WebAPI.Entities;

namespace ProductsCatalog.WebAPI.Services;

public interface IProductService
{
    List<Product> GetProducts();
    Product GetProduct(Guid id);
    void AddProduct(Product product);
    void UpdateProduct(Guid id, Product updateProduct);
    void DeleteProduct(Guid id);
}
