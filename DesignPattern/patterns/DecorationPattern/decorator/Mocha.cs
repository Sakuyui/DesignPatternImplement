namespace DesignPattern.patterns.DecorationPattern
{
    public class Mocha : CondimentDecorator
    {
        protected Beverage Beverage; //重要 

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return 4 + Beverage.Cost();
        }

        public override string GetDescribe()
        {
            return Beverage.Describe + ", Mocha";
        }
    }
}