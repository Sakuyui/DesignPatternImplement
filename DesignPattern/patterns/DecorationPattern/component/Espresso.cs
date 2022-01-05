namespace DesignPattern.patterns.DecorationPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Describe = "Espresso";
        }
        public override double Cost()
        {
            return 2;
        }
    }
}