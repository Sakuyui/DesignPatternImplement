namespace DesignPattern.patterns.ObserverPattern
{
    public interface IObserver
    {
        void Notify(object sender, object data); //通知
    }
}