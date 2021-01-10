namespace Observer
{
    public class WeatherStation
    {
        private static void Main()
        {
            WeatherData weatherData = new();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            //TODO: Implement StatisticsDisplay and ForecastDisplay classes
            //var statisticsDisplay = new CurrentConditionsDisplay(weatherData);
            //var forecastDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(new WeatherInfo(80, 65, 30.4f));
            weatherData.SetMeasurements(new WeatherInfo(82, 70, 29.2f));
            weatherData.SetMeasurements(new WeatherInfo(78, 90, 29.2f));
        }
    }
}