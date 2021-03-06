﻿using System;

namespace Observer
{
    public sealed class HeatIndexDisplay : IObserver<WeatherInfo>, IDisplayElement
    {
        private float _heatIndex;
        private IDisposable _unsubscriber;

        public HeatIndexDisplay(IObservable<WeatherInfo> observable)
        {
            Subscribe(observable);
        }

        public void Display()
        {
            Console.WriteLine($"Heat index is {_heatIndex}");
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
            _heatIndex = ComputeHeatIndex(weatherInfo.Temperature, weatherInfo.RelativeHumidity);
            Display();
        }

        private static float ComputeHeatIndex(float t, float rh)
        {
            return (float) (16.923 + 0.185212 * t + 5.37941 * rh - 0.100254 * t * rh
                            + 0.00941695 * (t * t) + 0.00728898 * (rh * rh)
                            + 0.000345372 * (t * t * rh) - 0.000814971 * (t * rh * rh) +
                            0.0000102102 * (t * t * rh * rh) - 0.000038646 * (t * t * t) + 0.0000291583 *
                            (rh * rh * rh) + 0.00000142721 * (t * t * t * rh) +
                            0.000000197483 * (t * rh * rh * rh) - 0.0000000218429 * (t * t * t * rh * rh) +
                            0.000000000843296 * (t * t * rh * rh * rh) -
                            0.0000000000481975 * (t * t * t * rh * rh * rh));
        }

        public void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        public void Subscribe(IObservable<WeatherInfo> observer)
        {
            _unsubscriber = observer.Subscribe(this);
        }
    }
}