using System;
using DesignPattern.patterns.ObserverPattern.entity;

namespace DesignPattern.patterns.ObserverPattern.subjects
{
    public class WeatherChangedEventArgs : EventArgs
    {
        public WeatherData WeatherData;
        public WeatherChangedEventArgs(WeatherData data)
        {
            WeatherData = data;
        }
    }
}