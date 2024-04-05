using webapi.Controllers;

namespace webapi.Services
{
    public class HelloWorldService: IHelloWorldService
    {
        private readonly ILogger<WeatherForecastController> _logger;


        public string GetHelloWorld()
        {
            return "Hello World!";
        }
    }

    public interface IHelloWorldService
    {
        string GetHelloWorld();
    }
}
