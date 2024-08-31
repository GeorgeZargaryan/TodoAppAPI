using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models.Model;
using TodoAPI.Services.Abstracts;

namespace TodoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ILogger<TaskController> _logger;
    private readonly ITaskService _taskService;

    public TaskController(ILogger<TaskController> logger, ITaskService taskService)
    {
        _logger = logger;
        _taskService = taskService;
    }

    [HttpGet("GetTasks")]
    public IActionResult GetAll()
    {
        _logger.LogInformation("Get Tasks");
        return Ok(_taskService.GetAll());
    }

    [HttpGet("GetTaskById/{id}")]
    public IActionResult GetById(int id)
    {
        _logger.LogInformation("Get Task By Id");
        return Ok(_taskService.GetById(id));
    }

    [HttpPost("AddTask")]
    public IActionResult Add(TodoTask task, string userId)
    {
        _logger.LogInformation("Add Task");

        _taskService.Add(task);

        return Ok();
    }

    [HttpDelete("RemoveTask")]
    public IActionResult Remove(string userId, int taskId)
    {
        _logger.LogInformation("Removing Task");

        _taskService.Remove(userId, taskId);

        return Ok();
    }

}
