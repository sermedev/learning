using Microsoft.AspNetCore.Mvc;
using webapi.Services;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController: ControllerBase
    {
        IHelloWorldService _helloWorldService;
        TasksContext _dbContext;

        public HelloWorldController(IHelloWorldService helloWorldService, TasksContext dbContext)
        {
                _helloWorldService = helloWorldService;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_helloWorldService.GetHelloWorld());
        }

        [HttpGet]
        [Route("createdb")]
        public IActionResult CreateDatabase()
        {
            _dbContext.Database.EnsureCreated();
             return Ok();
        }
    }
}
