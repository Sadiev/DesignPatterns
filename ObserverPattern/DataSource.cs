using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class DataSource: Subject
    {
        private int year;
        public int Year 
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
                notifyObservers();
            }
        }
    }
}
