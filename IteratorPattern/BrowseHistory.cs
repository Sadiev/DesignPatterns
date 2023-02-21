using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class BrowseHistory
    {
        private List<string> urls = new List<string>();
        public void push(string url)
        { urls.Add(url); }
        public string pop()
        {
            var lastIndex=urls.Count-1;
            var lastUrl = urls[lastIndex];
            urls.RemoveAt(lastIndex);
            return lastUrl;
        }
        public Iterator createIterator()
        {
            return new ListIterator(this);
        }
        public class ListIterator : Iterator
        {
            private BrowseHistory history;
            private int index;
            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }
            public string current()
            {
                return history.urls[index];
            }

            public bool hasNext()
            {
                return (index<history.urls.Count);
            }

            public void next()
            {
                index++;
            }
        }
    }
}
