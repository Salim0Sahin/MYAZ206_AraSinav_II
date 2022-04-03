using Array;
using Stack.Contracts;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class StaticArrayStack<T> : IStack<T>
    {
        // Propert ve Field tanımlamaları 10 puan
        private readonly Array<T> _innerArray;

        // Count implementasyonu 10 puan
        public int Count => throw new NotImplementedException();

        // Constructor tanımlaması 10 puan
        public StaticArrayStack(int defaultSize = 4)
        {
            throw new NotImplementedException();
        }

        // GetEnumerator implementasyonu 10 puan
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // Peek 10 puan
        public T Peek()
        {
            // Yığından çıkarılacak eleman yoksa StackDataStructureUnderflowException fırlatmalı.
            throw new NotImplementedException();
        }

        // Pop 20 Puan
        public T Pop()
        {
            // Yığından çıkarılacak eleman yoksa StackDataStructureUnderflowException fırlatmalı.
            throw new NotImplementedException();
        }

        // Push 20 puan
        public void Push(T item)
        {
            // Yığında yer yoksa StackDataStructureOverflowException fırlatmalı.
            throw new NotImplementedException();
        }

        // private GetEnumerator implementasyonu 10 puan
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
