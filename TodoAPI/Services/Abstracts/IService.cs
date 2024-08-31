namespace TodoAPI.Services.Abstracts;

public interface IService <T,K> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(K id);
    void Remove(string userId, int taskId);
    void Add(T entity);

}