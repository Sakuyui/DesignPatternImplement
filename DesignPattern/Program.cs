using DesignPattern.patterns;
using DesignPattern.patterns.DecorationPattern;
using DesignPattern.patterns.ObserverPattern;
using DesignPattern.patterns.StrategyPattern;

namespace DesignPattern
{/*设计原则 1： 抽象出可以变化的部分*/
    /*设计原则 2： 针对接口编程而不是针对实现编程*/
    /*设计原则 3: 多用组合，少用继承*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            StrategyPatternTest.Test();
            ObserverPatternTest.Test();
            DecoratorPatternTest.Test();
        }
    }
}