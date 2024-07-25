using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.ViewComponents
{
    public class CityViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather model)
        {
            ViewBag.CssByDegree = GetCssClassByFahrenheit(model.TemperatureFahrenheit);
            return View(model);
        }

        // function: to get CSS background color based on the degree range

        private string GetCssClassByFahrenheit(int TemperatureFahrenheit)
        {
            return TemperatureFahrenheit switch
            {
                (< 44) => "blue-back",
                (>= 44) and (< 78) => "green-back",
                (>= 75) => "orange-back"
            };
        }
    }
}

