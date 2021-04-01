using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2_EmmaSpiteri
{
    class Stack<T>
    {
        private List<T> elements = new List<T>();

        public int size()
        {
            return elements.Count;

        }

        public void Push(T element)
        {
            elements.Add(element);
        }

        public T Pop()
        {
            T objectToReturn = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);

            return objectToReturn;
        }

        public T Peek()
        {
            T objectToReturn = elements[elements.Count - 1];

            return objectToReturn;

        }

    }
}
