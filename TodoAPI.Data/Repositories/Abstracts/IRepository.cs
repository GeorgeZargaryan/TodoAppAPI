namespace TodoAPI.Data.Repositories.Abstracts;

public interface IRepository<T> : IDisposable
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Remove(T entity);
    void Add(T entity);
    void SaveChanges();
}