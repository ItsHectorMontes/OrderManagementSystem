namespace OrderManagementSystem.Interfaces;

// Generic repository for common CRUD operations
public interface IRepository<T>
{
    void Add(T entity);
    void Remove(int id);
    T GetById(int id);
    IEnumerable<T> GetAll();
}
