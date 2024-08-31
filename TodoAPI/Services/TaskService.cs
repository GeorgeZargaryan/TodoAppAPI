using Microsoft.AspNetCore.Mvc;
using TodoAPI.Data.Repositories.Abstracts;
using TodoAPI.Models.Model;
using TodoAPI.Services.Abstracts;

namespace TodoAPI.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;
    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void Add(TodoTask task) 
    {
        _taskRepository.Add(task);
        _taskRepository.SaveChanges();
    } 

    public IEnumerable<TodoTask> GetAll() => _taskRepository.GetAll();

    public TodoTask GetById(int id) => _taskRepository.GetById(id);

    public void Remove(string userId, int taskId)
    {
        var task = _taskRepository.GetById(taskId);

        _taskRepository.Remove(task);
    }
}
