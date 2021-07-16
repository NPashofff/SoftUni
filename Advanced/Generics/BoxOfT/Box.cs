using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private readonly Queue<T> elements = new Queue<T>();

        public int Count
        {
            get
            {
                return elements.Count;
            }

        }

        public void Add(T element)
        {
            elements.Enqueue(element);
        }

        public T Remove()
        {
            return elements.Dequeue();
        }


        
    }
}
