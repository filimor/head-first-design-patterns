using System;

namespace Observer
{
    public class ForecastDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private WeatherInfo _weatherInfo;
        private WeatherInfo _lastWeatherInfo;
        private IDisposable _unsubscriber;

        public ForecastDisplay(IObservable<WeatherInfo> observable)
        {
            Subscribe(observable);
        }

        public void Display()
        {
            Console.Write("Forecast: ");

            if (_weatherInfo.Pressure > _lastWeatherInfo.Pressure)
            {
                Console.WriteLine("Improving on the way!");
            }
            else if (_weatherInfo.Pressure < _lastWeatherInfo.Pressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
            else
            {
                Console.WriteLine("More of the same");
            }
        }

        public void OnCompleted()
        {
            // Do nothing.
        }

        public void OnError(Exception error)
        {
            // Do nothing.
        }

        public void OnNext(WeatherInfo weatherInfo)
        {
            _lastWeatherInfo = _weatherInfo;
            _weatherInfo = weatherInfo;

            Display();
        }

        public void Subscribe(IObservable<WeatherInfo> observer)
        {
            _unsubscriber = observer.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}