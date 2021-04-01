using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2_EmmaSpiteri
{
    public class Queuet<T>
    {
        private List<T> queue = new List<T>();

        public int Size { get { return queue.Count; } }

        public void Enque(T elem)
        {
            queue.Insert(0, elem);
        }

        public T Dequeue()
        {

            if(Size == 0)
            {
                throw new InvalidOperationException("There is no element");
            }
            
            T elementToReturn = queue[Size - 1];
            queue.RemoveAt(Size - 1);

            return elementToReturn;
        }

    }
}
