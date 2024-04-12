using Microsoft.AspNetCore.Mvc;
using webapi.Services;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    ITaskService taskService;

    public TaskController(ITaskService service)
    {
        taskService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(taskService.Get());
    }
}