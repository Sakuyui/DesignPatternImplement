using System;

namespace DesignPattern.patterns.ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {

        public void Display()
        {
            //显示天气预报
        }

        public void Notify(object sender, object data)
        {
            throw new NotImplementedException();
        }

      
    }
}