namespace DesignPattern.patterns.FactoryPattern
{
    /*
     *简单工程方法希望首先有一个抽象的产品和抽象的工厂类，各种工厂和产品分别继承这两个抽象类，工厂抽象类中创建一个创建产品的抽象方法（在子类中具体实现），
     * 并用一个函数负责返回这个产品
     * 
     */
    /*设计原则+1：要依赖抽象不要依赖具体。如果不抽象Pizza，PizzaStore会依赖各种具体的Pizza，因为是在PizzaStore的orderPizza()方法中实例化这些东西的*/
    /*依赖倒置如何思考：不要从顶端思考（Pizza），而是从自底向上思考（各种具体类）。*/
    public static class SimpleFactoryPatternTest{
        public static void Test()
        {
            var pz = new NyPizzaStore();
            pz.OrderPizza("cheese");
        }
    }
}