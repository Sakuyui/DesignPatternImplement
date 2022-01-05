using System;

namespace DesignPattern.patterns.ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {

        public void Display()
        {
            //显示统计数据，最大最小值等
        }

        public void Notify(object sender, object data)
        {
            throw new NotImplementedException();
        }
    }
}