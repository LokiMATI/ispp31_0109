using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class Sensor
    {
        private List<IObserver> _observers = new();

        public int Temperature;

        public int Pressure;

        public void AddObserver(IObserver observer) 
            => _observers.Add(observer);

        public void RemoveObserver(IObserver observer) 
            => _observers.Remove(observer);

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
    }
}