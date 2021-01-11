using System;

namespace Observer
{
    internal class ForecastDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private IDisposable _unsubscriber;
        private WeatherInfo _weatherInfo;
        private WeatherInfo _lastWeatherInfo;

        public ForecastDisplay(IObservable<WeatherInfo> observable)
        {
            Subscribe(observable);
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

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        public virtual void Subscribe(IObservable<WeatherInfo> observer)
        {
            _unsubscriber = observer.Subscribe(this);
        }
    }
}