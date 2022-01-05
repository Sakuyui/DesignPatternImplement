using DesignPattern.patterns.StrategyPattern.strategies;

namespace DesignPattern.patterns.StrategyPattern
{
    internal class MallardDuck : Duck{
        public MallardDuck() : base(new FlyWithWings())
        {
            
        }
    }
}