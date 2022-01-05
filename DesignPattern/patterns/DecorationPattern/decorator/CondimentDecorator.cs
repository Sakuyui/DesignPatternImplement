namespace DesignPattern.patterns.DecorationPattern
{
    public abstract class CondimentDecorator : Beverage //这里的继承不是为了获得行为，而是为了类型匹配
    {
        
        public abstract override double Cost();
        public abstract override string GetDescribe();
    }
}