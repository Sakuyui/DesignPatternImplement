using System.Security.Cryptography;

namespace DesignPattern.patterns.DecorationPattern
{
    public abstract class Beverage
    {
        public string Describe;
        public abstract double Cost();
        public virtual string GetDescribe() => Describe;
    }
}