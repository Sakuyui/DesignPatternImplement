namespace DesignPattern.patterns
{
    /*
     * 抽象工厂选择继续把工厂抽象。一个工厂可能需要多种材料，所以不妨把创建这些材料的方法抽象出来
     * 各类型原料也分别抽象
     */
    public class AbstractFactory
    {
        internal interface IAbstractFactory
        {
            IAbstractProductA CreateProductA();
            IAbstractProductB CreateProductB();
        }


        internal class ConcreteFactory1 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            {
                throw new System.NotImplementedException();
            }

            public IAbstractProductB CreateProductB()
            {
                throw new System.NotImplementedException();
            }
        }
        
        
        internal class ConcreteFactory2 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            {
                throw new System.NotImplementedException();
            }

            public IAbstractProductB CreateProductB()
            {
                throw new System.NotImplementedException();
            }
        }
        
        internal interface IAbstractProductA
        {
            
        }


        internal class ProductA1 : IAbstractProductA
        {
            
        }

        internal class ProductA2 : IAbstractProductA
        {
            
        }
        internal interface IAbstractProductB
        {
            
        }
        internal class ProductB1 : IAbstractProductB
        {
            
        }

        internal class ProductB2 : IAbstractProductB
        {
            
        }

        internal class Client
        {
            private IAbstractFactory _abstractFactory;

            public Client(IAbstractFactory abstractFactory)
            {
                _abstractFactory = abstractFactory;
            }

            public void CreateFinalProduct()
            {
                var pa = CreateFinalProductA();
                var pb = CreateFinalProductB();
                //combine
            }

            private IAbstractProductA CreateFinalProductA()
            {
                return _abstractFactory.CreateProductA();
            }

            private IAbstractProductB CreateFinalProductB()
            {
                return _abstractFactory.CreateProductB();
            }
        }
    }
}