using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Group: IComponent
    {
        private List<IComponent> components = new List<IComponent>();
        public void add(IComponent component) { components.Add(component); }

        public void move()
        {
            foreach (IComponent component in components)
            {
                component.move();
            }
        }

        public void render()
        { 
            foreach (IComponent component in components)
            {
                component.render();
            }
        } 
    }
}
