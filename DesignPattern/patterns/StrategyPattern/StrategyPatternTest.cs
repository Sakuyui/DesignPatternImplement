namespace DesignPattern.patterns.StrategyPattern
{
    /*策略模式，首先把策略抽象成一个策略接口，再用多个具体策略类实现这个接口，实现具体的策略。
     在需要使用策略的实体类中，接口作为一个属性组合使用。
     */
    public static class StrategyPatternTest
    {
        public static void Test()
        {
            var duck = new MallardDuck();
            duck.Fly();
        }
    }
}