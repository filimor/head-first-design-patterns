using System;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private IDisposable _unsubscriber;

        public CurrentConditionsDisplay(IObservable<WeatherInfo> observable)
        {
            observable.Subscribe(this);
        }

        public void Display(WeatherInfo weatherInfo)
        {
            Console.WriteLine($"Current conditions: {weatherInfo.Temperature} F degrees and {weatherInfo.Humidity} % humidity");
        }

        public void OnCompleted()
        {
            //TODO: Is it necessary?
            Unsubscribe();
        }

        public void OnError(Exception error)
        {
            // Do nothing.
        }

        public void OnNext(WeatherInfo value)
        {
            Display(value);
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