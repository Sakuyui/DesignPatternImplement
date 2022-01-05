namespace DesignPattern.patterns.FactoryPattern
{
    internal abstract class Pizza
    {
        public string Name;
        public string Dough;
        public string Sauce;
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}