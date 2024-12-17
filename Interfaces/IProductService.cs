using OrderManagementSystem.Entities;

namespace OrderManagementSystem.Interfaces;

// Product service interface for managing products
public interface IProductService
{
    void AddProduct(Product product);
    Product GetProductById(int id);
    IEnumerable<Product> GetAvailableProducts();
    void DeductStock(int productId, int quantity);
}
