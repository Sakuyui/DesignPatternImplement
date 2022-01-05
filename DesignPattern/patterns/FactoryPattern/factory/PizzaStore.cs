namespace DesignPattern.patterns.FactoryPattern
{
    internal abstract class PizzaStore
    {
        //protected readonly SimplePizzaFactory Factory;
        //public PizzaStore(SimplePizzaFactory factory) => Factory = factory;
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        
        public abstract Pizza CreatePizza(string type);
    }
}