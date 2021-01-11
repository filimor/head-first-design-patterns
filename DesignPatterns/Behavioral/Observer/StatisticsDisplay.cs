using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class StatisticsDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private readonly List<WeatherInfo> _weatherInfos;
        private IDisposable _unsubscriber;

        public StatisticsDisplay(IObservable<WeatherInfo> observable)
        {
            _weatherInfos = new List<WeatherInfo>();
            Subscribe(observable);
        }

        public void Display()
        {
            float minTemp = _weatherInfos.Min(x => x.Temperature);
            float maxTemp = _weatherInfos.Max(x => x.Temperature);
            float avgTemp = _weatherInfos.Average(x => x.Temperature);

            Console.WriteLine($"Avg/Max/Min temperature = {avgTemp} / {maxTemp} / {minTemp}");
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
            _weatherInfos.Add(weatherInfo);
            Display();
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