using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlerExpiresHeaderBug.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            throw new DivideByZeroException("The exception !");
        }
    }
}
