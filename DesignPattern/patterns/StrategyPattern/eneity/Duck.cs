using DesignPattern.patterns.StrategyPattern.strategies;

namespace DesignPattern.patterns.StrategyPattern
{
    internal abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
    
        //在C#也可以定义委托
        private Strategies.FlyBehaviorStrategy _flyBehaviorStrategy; //用委托实现的方式
        protected Duck(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void Fly() => _flyBehavior.Fly();
    }
}