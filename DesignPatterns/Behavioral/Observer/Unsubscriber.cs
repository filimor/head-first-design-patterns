using System;
using System.Collections.Generic;

namespace Observer
{
    public class Unsubscriber : IDisposable
    {
        private readonly IObserver<WeatherInfo> _observer;
        private readonly List<IObserver<WeatherInfo>> _observers;

        public Unsubscriber(List<IObserver<WeatherInfo>> observers, IObserver<WeatherInfo> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null)
            {
                _observers.Remove(_observer);
            }

            GC.SuppressFinalize(this);
        }
    }
}