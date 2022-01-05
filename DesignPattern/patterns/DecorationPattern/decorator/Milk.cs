namespace DesignPattern.patterns.DecorationPattern
{
    public class Milk : CondimentDecorator
    {
        private Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return 3 + _beverage.Cost();
        }

        public override string GetDescribe()
        {
            return _beverage.Describe + ", Milk";
        }
    }
}