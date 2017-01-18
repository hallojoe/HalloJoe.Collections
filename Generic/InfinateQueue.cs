using System.Collections.Generic;
namespace HalloJoe.Collections.Generic
{
    public class InfiniteQueue<T> : Queue<T>
    {
        public new T Dequeue()
        {
            T item = base.Dequeue();
            Enqueue(item);
            return item;
        }
    }
}
