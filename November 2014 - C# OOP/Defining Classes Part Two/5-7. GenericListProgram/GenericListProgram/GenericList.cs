using System;
using System.Text;

namespace GenericListProgram
{
    class GenericList<T>
    {
        //fields
        private T[] arr = null;

        //properties
        public uint Capacity { get; private set; }
        public uint Count { get; private set; }

        //constructors
        public GenericList(uint capacity)
        {
            this.Capacity = capacity;
            this.Count = 0;

            this.arr = new T[this.Capacity];
        }

        //methods
        public void Add(T element)
        {
            this.arr[this.Count] = element;

            if (this.Count < this.Capacity) //auto-grow if needed
            {
                this.Count++;
            }
            else
            {
                int newSize = (int)(2 * this.Capacity);
                Array.Resize<T>(ref this.arr, newSize);
                //arr = Grow(arr);
            }
        }

        public T GetElementAt(uint elementID)
        {
            if (elementID > this.Count - 1)
            {
                throw new IndexOutOfRangeException("There is no element at the requested index to be returned");
            }
            return this.arr[elementID];
        }

        public void RemoveElemementAt(uint elementID)
        {
            if (elementID < this.Count)
            {
                for (uint i = elementID; i < this.Count; i++)
                {
                    this.arr[elementID] = this.arr[elementID + 1];
                }
                this.arr[this.Count] = default(T);
                this.Count--;
            }
            else
            {
                throw new IndexOutOfRangeException("There is no element at the requested index to be removed.");
            }
        }

        public void InsertElementAt(uint index, T element)
        {
            if (index <= this.Count)
            {
                if (this.Count < this.Capacity) //auto-grow if needed
                {
                    this.Count++;
                }
                else
                {
                    this.arr = Grow(this.arr);
                }

                for (uint i = this.Count; i > index; i--)
                {
                    this.arr[i] = this.arr[i - 1];
                }

                this.arr[index] = element;
            }
        }

        public long FindElement(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (element.Equals(this.arr[i]))
                {
                    return i;
                }
            }
            return -1; //that means not found.
        }

        public override string ToString()
        {
            string output = "Capacity: " + this.Capacity + "; \nCount: " + this.Count + "; \n" + "Elements: ";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append("\n");
                sb.Append(this.arr[i]);
            }

            output += Convert.ToString(sb);

            return output;
        }

        private T[] Grow(T[] arr) //FIX. seems like its not working
        {
            T[] newArr = new T[this.Capacity * 2];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        public T Min()
        {
            T min = arr[0];
            for (int i = 1; i < this.Count; i++)
            {
                if ((dynamic)this.arr[i] < min)
                {
                    min = this.arr[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = arr[0];
            for (int i = 1; i < this.Count; i++)
            {
                if ((dynamic)this.arr[i] > max)
                {
                    max = this.arr[i];
                }
            }
            return max;
        }

    }
}
