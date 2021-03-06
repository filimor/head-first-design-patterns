﻿using System;
using System.Collections.Generic;

namespace Observer
{
    public class WeatherData : IObservable<WeatherInfo>
    {
        private readonly List<IObserver<WeatherInfo>> _observers;
        private WeatherInfo _weatherInfo;

        public WeatherData()
        {
            _observers = new List<IObserver<WeatherInfo>>();
        }

        public void SetMeasurements(WeatherInfo weatherInfo)
        {
            _weatherInfo = weatherInfo;

            foreach (var observer in _observers)
            {
                observer.OnNext(weatherInfo);
            }
        }

        public float GetTemperature()
        {
            return _weatherInfo.Temperature;
        }

        public float GetHumidity()
        {
            return _weatherInfo.Humidity;
        }

        public float GetPressure()
        {
            return _weatherInfo.Pressure;
        }

        public void EndTransmission()
        {
            foreach (var observer in _observers.ToArray())
            {
                if (_observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            }

            _observers.Clear();
        }

        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber(_observers, observer);
        }
    }
}