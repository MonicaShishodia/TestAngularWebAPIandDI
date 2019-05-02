using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abstraction;
using Abstraction.Entity;
namespace TestCLIAngular3.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly IUser _user;
        public SampleDataController(IUser user) => _user = user;
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }
        [HttpGet("GetUsers")]
        public List<TestTable> GetUsers() => _user.GetUsers();
        [HttpPost("Add")]
        public bool Add(TestTable o) => _user.AddUser(o);
        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
