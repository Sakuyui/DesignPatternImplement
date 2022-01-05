using System;

namespace DesignPattern.patterns.FactoryPattern
{
    internal class ChicagoStore : PizzaStore
    {
        
        public override Pizza CreatePizza(string type)
        {
            throw new NotImplementedException();
        }
    }
}