using System.Collections;

namespace Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {

        private int position;
        public int Count => position;
        private T[] InnerArray { get; set; }

        public int Length => InnerArray.Length;

        public Array(int defaultSize = 2)
        {
            InnerArray = new T[defaultSize];
            position = 0;
        }

        public Array(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
                Add(item);
        }

        public void Add(T value)
        {
            if (position == Length)
                DoubleArray();

            if (position < Length)
            {
                InnerArray[position] = value;
                position += 1;
                return;
            }
            throw new ArgumentException();
        }
        public T Remove()
        {
            if (position >= 0)
            {
                var temp = InnerArray[position - 1];
                position = position - 1;
                if (position == InnerArray.Length / 4)
                    HalfArray();
                return temp;
            }
            throw new ArgumentOutOfRangeException("");
        }

        private void DoubleArray()
        {
            try
            {
                var temp = new T[InnerArray.Length * 2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void HalfArray()
        {
            try
            {
                var temp = new T[InnerArray.Length / 2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length / 2);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(InnerArray);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void SetValue(T value, int index)

        {
            if (!(index >= 0 && index < InnerArray.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }
            InnerArray[index] = value;
            return;
        }

        public T GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }
            return InnerArray[index];
        }


    }
}