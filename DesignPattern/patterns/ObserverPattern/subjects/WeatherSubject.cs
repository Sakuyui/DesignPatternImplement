using System;
using System.Collections.Generic;
using System.Threading;
using DesignPattern.patterns.ObserverPattern.entity;

namespace DesignPattern.patterns.ObserverPattern.subjects
{
    public class WeatherSubject : ISubject
    {
        //c# event实现方式
        public event EventHandler<WeatherChangedEventArgs> WeatherChanged;
        //event这个关键字很有讲究。
        /*
         * 编译时发生了什么，
         * 1. 生成了一个私有委托 private EventHandler<WeatherChangedEventArgs> WeatherChanged = null;
         * 2. 一个public的add_WeatherChanged(EventHandler<xxxArgs> value)方法,相当于观察者模式下subject的 registerObserver();
         * 3. 一个公共的remove_xxxxx()方法  相当于观察者模式下subject的removeObserver()
         */
        
        
        protected virtual void OnWeatherChanged(WeatherChangedEventArgs e)
        {
            var temp = Volatile.Read(ref WeatherChanged);
            if (temp != null) temp(this, e);
        }

        

        private WeatherData _weatherData = new WeatherData();
        
        
        public double Temperature
        {
            get => _weatherData.Temperature;
            set
            {
                _weatherData.Temperature = value;
                //要
                MeasurementsChanged();
                //c# event方式
                OnWeatherChanged(new WeatherChangedEventArgs(_weatherData));
            }
        }

        public double Humidity
        {
            get => _weatherData.Humidity;
            set
            {
                _weatherData.Humidity = value;
                MeasurementsChanged();
                OnWeatherChanged(new WeatherChangedEventArgs(_weatherData));
            }
        }

        public double Pressure
        {
            get => _weatherData.Pressure;
            set
            {
                _weatherData.Pressure = value;
                MeasurementsChanged();
                OnWeatherChanged(new WeatherChangedEventArgs(_weatherData));
            }
        }


        //要点：Subject需要加一个观察者集合
        private List<IObserver> _observers = new List<IObserver>();

        //要点
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var i in _observers)
            {
                i.Notify(this, _weatherData);
            }
        }

      
    }
}