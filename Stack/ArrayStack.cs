using Array;
using Stack.Contracts;
using System.Collections;

namespace Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        public int Count => _Array.Count;

        private readonly Array<T> _Array = new Array<T>();

        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Empty stack");
            }

            var result = _Array.Remove();
            return result;
        }

        public void Push(T item)
        {
            _Array.Add(item);
        }

        public T Peek()
        {
            if (Count == 0)
            {
                return default;
            }

            return _Array.GetValue(_Array.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _Array.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Array.GetEnumerator();
        }
    }
}