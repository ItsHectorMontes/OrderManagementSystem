namespace OrderManagementSystem.Entities;

// Represents an Order entity
public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public List<Product> Products { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount => Products.Sum(p => p.Price);

    public Order()
    {
        Products = new List<Product>();
    }
}
