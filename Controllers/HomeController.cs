using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;
using WeatherApp.WeatherService;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var cities = _weatherService.GetWeatherDetails();
            return View(cities);
        }

        [Route("city-details/{cityCode?}")]
        public IActionResult CityCode(string? cityCode)
        {
            if (string.IsNullOrEmpty(cityCode))
            {
                return View();
            }

            CityWeather? matchingCity = _weatherService.GetWeatherByCityCode(cityCode);
            return View(matchingCity);
        }
    }
}
