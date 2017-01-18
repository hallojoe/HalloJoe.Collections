using System.Collections.Concurrent;
namespace HalloJoe.Collections.Concurrent
{
    public class InfiniteQueue<T> : ConcurrentQueue<T>
    {
        public new bool TryDequeue(out T result)
        {
            if (base.TryDequeue(out result))
            {
                Enqueue(result);
                return true;
            }
            return false;
        }
    }
}
