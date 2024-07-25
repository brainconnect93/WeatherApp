using WeatherApp.Models;
using WeatherApp.WeatherService;

namespace WeatherApp.Service
{
    public class Services : IWeatherService
    {
        private readonly List<CityWeather> _cityWeather;
        public Services()
        {
            _cityWeather = new List<CityWeather>()
            {
                new CityWeather()
                {
                    CityUniqueCode = "°F",
                    CityName = "London",
                    DateAndTime = DateTime.Parse("08:00 AM"),
                    TemperatureFahrenheit = 33
                },
                new CityWeather()
                {
                    CityUniqueCode = "°F",
                    CityName = "New York",
                    DateAndTime = DateTime.Parse("03:00 AM"),
                    TemperatureFahrenheit = 60
                },
                new CityWeather()
                {
                    CityUniqueCode = "°F",
                    CityName = "Paris",
                    DateAndTime = DateTime.Parse("09:00 AM"),
                    TemperatureFahrenheit = 82
                }
            };
        }

        public CityWeather? GetWeatherByCityCode(string CityCode)
        {
            CityWeather? city = _cityWeather.FirstOrDefault(x => x.CityUniqueCode == CityCode);
            return city;
        }

        public List<CityWeather> GetWeatherDetails()
        {
            return _cityWeather;
        }
    }
}
