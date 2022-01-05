namespace DesignPattern.patterns.DecorationPattern
{
    public static class DecoratorPatternTest
    {
        /*装饰者模式主要存在两种东西：组件和装饰器。装饰器继承抽象组件，但是继承不是为了继承行为，而是为了保证类型一致。
         并且为了用上组件通用属性，在具体装饰器中使用组件成员。
         装饰器构造中，应该传入组件
         */
        public static void Test()
        {
            var espresso = new Espresso();
            var milk = new Milk(espresso);
            
            (milk.GetDescribe(), milk.Cost()).PrintToConsole();
            (espresso.GetDescribe(), espresso.Cost()).PrintToConsole();
        }
    }
}