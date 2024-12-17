using OrderManagementSystem.Entities;
using OrderManagementSystem.Interfaces;
using OrderManagementSystem.Repositories;
using OrderManagementSystem.Services;

var productRepo = new GenericRepository<Product>();
var orderRepo = new GenericRepository<Order>();

IProductService productService = new ProductService(productRepo);
IOrderService orderService = new OrderService(orderRepo, productService);

// Add products
productService.AddProduct(new Product { Name = "Laptop", Price = 1000, Stock = 10 });
productService.AddProduct(new Product { Name = "Phone", Price = 500, Stock = 5 });

// Create an order
var order = new Order
{
    CustomerName = "John Doe",
    OrderDate = DateTime.Now,
    Products = new List<Product>
    {
        productService.GetProductById(1),
        productService.GetProductById(2)
    }
};

orderService.CreateOrder(order);

// Display all orders
Console.WriteLine("\nAll Orders:");
foreach (var o in orderService.GetAllOrders())
{
    Console.WriteLine($"ID: {o.Id}, Customer: {o.CustomerName}, Total: ${o.TotalAmount}");
}
