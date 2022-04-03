namespace DataStructures.LinkedList.CircularLinkedList
{
    public class CircularLinkedList<T>
    {
        private int count;
        private CirNode<T> tail;
        private CirNode<T> currentPrev;
        public int Count => this.count;
        public T CurrentItem => this.currentPrev.Next.Item;
        public CircularLinkedList()
        {
            this.count = 0;
            this.tail = null;
        }
        public bool IsEmpty()
        {
            return this.tail == null;
        }
        private CirNode<T> GetNodeByIndex(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("index", "Index out of range");
            }

            CirNode<T> tempNode = this.tail.Next;
            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }
            return tempNode;
        }
        public void Add(T value)
        {
            CirNode<T> newNode = new CirNode<T>(value);
            if (this.tail == null)
            {
                this.tail = newNode;
                this.tail.Next = newNode;
                this.currentPrev = newNode;
            }
            else
            {
                newNode.Next = this.tail.Next;
                this.tail.Next = newNode;
                if (this.currentPrev == this.tail)
                {
                    this.currentPrev = newNode;
                }
                this.tail = newNode;
            }
            this.count++;
        }
        public void Remove()
        {
            if (this.tail == null)
            {
                throw new NullReferenceException("There are no item in the linked list.");
            }
            else if (this.count == 1)
            {
                this.tail = null;
                this.currentPrev = null;
            }
            else
            {
                if (this.currentPrev.Next == this.tail)
                {
                    this.tail = this.currentPrev;
                }
                this.currentPrev.Next = this.currentPrev.Next.Next;
            }
            this.count--;
        }
        public string GetAllNodes()
        {
            if (this.count == 0)
            {
                throw new NullReferenceException("There are no elements in the linked list.");
            }
            else
            {
                CirNode<T> tempNode = this.tail.Next;
                string result = string.Empty;
                for (int i = 0; i < this.count; i++)
                {
                    result += tempNode.Item + " ";
                    tempNode = tempNode.Next;
                }

                return result;
            }
        }
        public void Move(int step = 1)
        {
            if (step < 1)
            {
                throw new ArgumentOutOfRangeException("step", "The number of moving steps cannot be less than 1");
            }

            for (int i = 1; i < step; i++)
            {
                currentPrev = currentPrev.Next;
            }
        }
    }
}
