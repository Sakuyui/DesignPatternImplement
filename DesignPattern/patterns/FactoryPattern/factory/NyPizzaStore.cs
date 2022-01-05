using System;

namespace DesignPattern.patterns.FactoryPattern
{
    internal class NyPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            throw new NotImplementedException();
        }
    }
}