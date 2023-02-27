using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Subject
    {
        private List<Observer> observers= new List<Observer>();
        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }
        public void removeObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void notifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update();
            }
        }
    }
}
