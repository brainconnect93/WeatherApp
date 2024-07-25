using WeatherApp.Models;

namespace WeatherApp.WeatherService
{
    public interface IWeatherService
    {
        List<CityWeather> GetWeatherDetails();

        CityWeather? GetWeatherByCityCode(string CityCode);
    }
}
