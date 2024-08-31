using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Data.Repositories.Abstracts;
using TodoAPI.Models.Model;

namespace TodoAPI.Data.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ApplicationDbContext _dbContext;
    private bool disposed = false;

    public TaskRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void Add(TodoTask task) => _dbContext.Tasks.Add(task);

    public IEnumerable<TodoTask> GetAll()
    {
        return _dbContext.Tasks.Select(t => t).AsNoTracking();
    }

    public TodoTask? GetById(int id)
    {
        return _dbContext.Tasks.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Remove(TodoTask task)
    {
        _dbContext.Tasks.Remove(task);
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
}