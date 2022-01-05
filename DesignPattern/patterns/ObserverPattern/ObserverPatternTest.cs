using DesignPattern.patterns.ObserverPattern.observers;
using DesignPattern.patterns.ObserverPattern.subjects;

namespace DesignPattern.patterns.ObserverPattern
{
    public static class ObserverPatternTest
    {
        //观察者模式主要分为 Subject和Observer两个部分。观察者可以被抽象，并且其中有一个notify(data)方法，
        //Subject需要包含数据，并且需要负责添加和去除观察者，通知观察者。
        //实际上也可以用c#的事件实现，
        /*
         * C#事件实现方式
         * 1.定义事件参数，继承EventArgs，里面包含事件数据
         * 2.定义事件管理类。其中使用event EventHandler<xxxArg>定义各类事件
         * 3.在事件管理器内，编写各种事件发生时的通知函数。形式为Onxxxxx(e)
         * 4.在事件管理器内定义产生事件的方法。
         * 5.观察者在事件管理对象的onxxxx中用+=运算符添加一个观测回调函数。
         * 6.在事件发生点，调用事件管理对象的事件产生函数。
         */
        public static void Test()
        {
            var subject = new WeatherSubject();
            var observer1 = new CurrentConditionDisplay();
            var observer2 = new CurrentConditionDisplay();
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);
            //c#方式
            subject.WeatherChanged += observer1.Notify;
            subject.WeatherChanged += observer2.Notify;
            //变化后将会收到通知
            subject.Temperature = 45.2;
            subject.Pressure = 14.2;
            
        }
    }
}