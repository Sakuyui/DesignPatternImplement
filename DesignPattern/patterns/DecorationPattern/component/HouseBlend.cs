namespace DesignPattern.patterns.DecorationPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Describe = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 1;
        }

       
    }
}