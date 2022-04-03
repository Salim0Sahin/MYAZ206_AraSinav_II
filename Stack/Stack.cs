using Stack.Contracts;
using System.Collections;

namespace Stack
{
    public class Stack<T> : IStack<T>
    {
        private readonly IStack<T> _stack;

        public int Count => _stack.Count;

        public Stack(StackType type = StackType.Array)
        {
            switch (type)
            {
                case StackType.Array:
                    _stack = new ArrayStack<T>();
                    break;
                case StackType.LinkedList:
                    _stack = new LinkedListStack<T>();
                    break;
                case StackType.StaticArrayStack:
                    _stack = new StaticArrayStack<T>();
                    break;
                default:
                    throw new Exception("Undefiend tye");
            }
        }

        public Stack(IEnumerable<T> collection) : this(StackType.LinkedList)
        {
            foreach (var item in collection)
                _stack.Push(item);
        }

        public void Push(T item)
        {
            _stack.Push(item);
        }

        public T Pop()
        {
            return _stack.Pop();
        }

        public T Peek()
        {
            return _stack.Peek();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}