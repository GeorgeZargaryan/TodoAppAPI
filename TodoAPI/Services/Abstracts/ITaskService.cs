using TodoAPI.Data.Repositories.Abstracts;
using TodoAPI.Models.Model;

namespace TodoAPI.Services.Abstracts;

public interface ITaskService : IService<TodoTask, int>
{
    IEnumerable<TodoTask> GetAll();
    TodoTask GetById(int id);
}