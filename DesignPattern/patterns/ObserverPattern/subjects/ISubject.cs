﻿namespace DesignPattern.patterns.ObserverPattern.subjects
{
    public interface ISubject
    {
        
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}