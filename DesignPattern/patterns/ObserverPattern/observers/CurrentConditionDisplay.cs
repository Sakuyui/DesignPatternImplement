using System;
using DesignPattern.patterns.ObserverPattern.entity;
using DesignPattern.patterns.ObserverPattern.subjects;

namespace DesignPattern.patterns.ObserverPattern.observers
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private WeatherData _weatherData;

        
        public void Display()
        {
            //显示当前观测值
            $"{_weatherData.Humidity}, {_weatherData.Pressure}, {_weatherData.Temperature}".PrintToConsole();
        }

        public void Notify(object sender, object data)
        {
            if (data is WeatherChangedEventArgs e)
            {
                $"this is observed from c# event".PrintToConsole();
                _weatherData = e.WeatherData;
            }
            else
            {
                $"this is observed from custom observer pattern".PrintToConsole();
                _weatherData = (WeatherData) data;
            }
            Display();
        }
    }
}