using OrderManagementSystem.Entities;

namespace OrderManagementSystem.Interfaces;

// Order service interface for managing orders
public interface IOrderService
{
    void CreateOrder(Order order);
    IEnumerable<Order> GetAllOrders();
    Order GetOrderById(int id);
}
