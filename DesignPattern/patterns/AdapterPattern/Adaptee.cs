namespace DesignPattern.patterns.AdapterPattern
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            
        }
    }

    public class Client
    {
        private Target _target;

        public Client(Target target)
        {
            _target = target;
        }

        public void Use()
        {
            _target.Request();
        }
    }
    public class Adapter : Target
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
    
    public abstract class Target
    {
        public abstract void Request();
    }
}