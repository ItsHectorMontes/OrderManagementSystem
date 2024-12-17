using OrderManagementSystem.Entities;
using OrderManagementSystem.Interfaces;
using OrderManagementSystem.Utilities;

namespace OrderManagementSystem.Services;

// Service for managing orders
public class OrderService : IOrderService
{
    private readonly IRepository<Order> _orderRepository;
    private readonly IProductService _productService;

    public OrderService(IRepository<Order> orderRepository, IProductService productService)
    {
        _orderRepository = orderRepository;
        _productService = productService;
    }

    public void CreateOrder(Order order)
    {
        // Validate order
        Validator.ValidateNotNull(order, "Order cannot be null");

        // Deduct stock for each product
        foreach (var product in order.Products)
        {
            _productService.DeductStock(product.Id, 1);
        }

        // Add order
        _orderRepository.Add(order);
        Console.WriteLine($"Order created for customer: {order.CustomerName}, Total: ${order.TotalAmount}");
    }

    public IEnumerable<Order> GetAllOrders()
    {
        return _orderRepository.GetAll();
    }

    public Order GetOrderById(int id)
    {
        return _orderRepository.GetById(id);
    }
}
