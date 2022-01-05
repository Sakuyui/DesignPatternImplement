using System;

namespace DesignPattern.patterns.ObserverPattern.observers
{
    //天气数据应该是一个主题


    //因为可能有多种东西需要利用那个Subject，所以把观察者也抽象化

    public class ThirdPartyDisplay : IObserver, IDisplayElement
    {

        public void Display()
        {
            
        }

        public void Notify(object sender, object data)
        {
            throw new NotImplementedException();
        }
    }
    
    
}