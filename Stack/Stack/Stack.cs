using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private readonly List<object> objects = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot put null object onto stack");
            }
            objects.Add(obj);
        }

        public object Pop()
        {
            if (objects.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            object lastItem = objects[objects.Count - 1];
            objects.RemoveAt(objects.Count -1);
            return lastItem;
            
        }

        public void Clear()
        {
            objects.Clear();
        }
    }
}
