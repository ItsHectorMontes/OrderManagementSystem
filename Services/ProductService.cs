using OrderManagementSystem.Entities;
using OrderManagementSystem.Interfaces;
using OrderManagementSystem.Utilities;

namespace OrderManagementSystem.Services;

// Service for managing products
public class ProductService : IProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductService(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public void AddProduct(Product product)
    {
        Validator.ValidateNotNull(product, "Product cannot be null");
        _productRepository.Add(product);
    }

    public Product GetProductById(int id)
    {
        return _productRepository.GetById(id);
    }

    public IEnumerable<Product> GetAvailableProducts()
    {
        return _productRepository.GetAll().Where(p => p.Stock > 0);
    }

    public void DeductStock(int productId, int quantity)
    {
        var product = GetProductById(productId);
        Validator.ValidateNotNull(product, "Product not found");

        if (product.Stock < quantity)
            throw new InvalidOperationException("Not enough stock");

        product.Stock -= quantity;
    }
}
