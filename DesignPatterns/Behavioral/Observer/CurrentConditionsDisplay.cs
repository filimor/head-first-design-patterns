using System;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private WeatherInfo _weatherInfo;
        private IDisposable _unsubscriber;

        public CurrentConditionsDisplay(IObservable<WeatherInfo> observable)
        {
            Subscribe(observable);
        }

        public void Display()
        {
            Console.WriteLine(
                $"Current conditions: {_weatherInfo.Temperature} F degrees and {_weatherInfo.Humidity} % humidity");
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