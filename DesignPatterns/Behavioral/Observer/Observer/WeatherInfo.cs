namespace Observer
{
    public readonly struct WeatherInfo
    {
        public float Humidity { get; }
        public float Temperature { get; }
        public float Pressure { get; }

        public WeatherInfo(float humidity, float temperature, float pressure)
        {
            Humidity = humidity;
            Temperature = temperature;
            Pressure = pressure;
        }
    }
}