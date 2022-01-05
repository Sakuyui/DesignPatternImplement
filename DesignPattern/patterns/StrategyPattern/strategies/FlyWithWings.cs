namespace DesignPattern.patterns.StrategyPattern.strategies
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            "fly with wings".PrintToConsole();
        }
    }
}