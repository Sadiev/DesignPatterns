using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal abstract class UIControl
    {
        //Observers
        private List<EventHandler> eventHandlers = new List<EventHandler>();
        //attach
        public void addEventHandler (EventHandler observer)
        {
            eventHandlers.Add(observer);
        }
        //notifyObservers
        protected void notifyEventHandlers()
        {
            foreach (var observer in eventHandlers)
            {
                observer.handle();
            }
        }
    }
}
