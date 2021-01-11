namespace Observer
{
    public struct WeatherInfo
    {
        public float Humidity { get; }
        public float Temperature { get; }
        public float Pressure { get; }
        public float RelativeHumidity { get; }

        public WeatherInfo(float humidity = 0f, float temperature = 0f, float pressure = 0f, float relativeHumidity = 0f)
        {
            Humidity = humidity;
            Temperature = temperature;
            Pressure = pressure;
            RelativeHumidity = relativeHumidity;
        }
    }
}