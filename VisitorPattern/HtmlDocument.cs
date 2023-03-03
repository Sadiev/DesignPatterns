using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class HtmlDocument
    {
        private List<HtmlNode> nodes = new List<HtmlNode>();
        public void add(HtmlNode node) { nodes.Add(node); }
        public void execute(Operation operation) 
        {
            foreach (var node in nodes)
            {
                node.execute(operation);
            }    
        }
    }
}
