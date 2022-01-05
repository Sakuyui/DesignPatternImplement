using System;
using System.Threading;

namespace DesignPattern.patterns.Singleton
{
    public class Singleton
    {
        
    }


    public class SingletonClass
    {
        public volatile static SingletonClass Instance;
        private SingletonClass(){}
        private static readonly object LockObj = new object();
        
        public static SingletonClass GetInstance()
        {
            if (Instance != null) 
                return Instance;
            
            lock (LockObj)
            {
                if (Instance != null) return Instance;
                var instance = new SingletonClass();
                Instance = instance;
            }

            return Instance;
        }
    }
}