using DataStructures.LinkedList.SinglyLinkedList;
using Stack.Contracts;
using System.Collections;

namespace Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        public int Count { get; private set; }

        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();

        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Empty stack");
            }

            var result = list.RemoveFirst();
            Count--;
            return result;
        }

        public void Push(T item)
        {
            list.AddFirst(item);
            Count++;
        }

        public T Peek()
        {
            return Count == 0 ? default : list.Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}