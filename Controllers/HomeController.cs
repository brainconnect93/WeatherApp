using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private List<CityWeather> weather = new List<CityWeather>()
            {

                new CityWeather()
                {
                    CityUniqueCode = "°F",
                    CityName = "London",
                    DateAndTime = DateTime.Parse("08:00 AM"),
                    TemperatureFehrenheit = 33
                },
                new CityWeather()
                {
                    CityUniqueCode = "°F",
                    CityName = "New York",
                    DateAndTime = DateTime.Parse("03:00 AM"),
                    TemperatureFehrenheit = 60
                },
                new CityWeather()
                {
                    CityUniqueCode = "°F",
                    CityName = "Paris",
                    DateAndTime = DateTime.Parse("09:00 AM"),
                    TemperatureFehrenheit = 82
                }
            };

        [Route("/")]
        public IActionResult Index()
        {
            return View(weather);
        }

        [Route("city-details/{name?}")]
        public IActionResult Details(string? name)
        {
            if(name == null)
            {
                return Content("City name can't be empty");
            }
            
            CityWeather? matchingCity = weather.Where(temp =>
            temp.CityName == name).FirstOrDefault();
            return View(matchingCity);
        }
    }
}
