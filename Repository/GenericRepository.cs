using OrderManagementSystem.Interfaces;

namespace OrderManagementSystem.Repositories;

// Generic repository implementation using an in-memory list
public class GenericRepository<T> : IRepository<T> where T : class
{
    private readonly List<T> _data = new List<T>();
    private int _currentId = 1;

    public void Add(T entity)
    {
        var idProperty = typeof(T).GetProperty("Id");
        idProperty?.SetValue(entity, _currentId++);
        _data.Add(entity);
    }

    public void Remove(int id)
    {
        var entity = GetById(id);
        if (entity != null)
            _data.Remove(entity);
    }

    public T GetById(int id)
    {
        return _data.FirstOrDefault(e =>
            (int)e.GetType().GetProperty("Id")?.GetValue(e, null) == id);
    }

    public IEnumerable<T> GetAll()
    {
        return _data;
    }
}
