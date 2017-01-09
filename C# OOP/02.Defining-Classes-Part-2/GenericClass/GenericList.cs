using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{   
    class GenericList<T> where T : IComparable<T>
    {
        private T[] elements;
        private int capacity;



        // Constructor
        public GenericList(int capacity)
        {
            this.Count = 0;
            this.elements = new T[capacity];
            this.capacity = capacity;
        }

        // Properties
        public int Count {
            get;

            private set;
        }
        
        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                this.capacity = value;
            }
        }

        public T[] Elements
        {
            get
            {
                return this.elements;
            }

            set
            {
                this.elements = value;
            }
        }

        //Methods

        public void Add(T item)
        {
            if (this.Count == this.Capacity)
            {
                this.Expand();
            }
            elements[this.Count] = item;
            this.Count++;
        }

        public void InsertValueAtIndex(T value, int index)
        {
            if (index >= this.Capacity)
            {
                throw new ArgumentOutOfRangeException("Index is greater than capacity!");
            }

            if (this.Count == this.Capacity)
            {
                this.Expand();
            }

            T[] subArray = new T[this.Capacity];

            for (int i = index; i < this.Count; i++)
            {
                subArray[i + 1] = elements[i];
            }

            elements[index] = value;

            for (int i = index + 1; i < this.Count + 1; i++)
            {
                elements[i] = subArray[i];
            }
        }

        private void Expand()
        {

            T[] newArray = new T[2 * this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
            this.Capacity *= 2;

        }

        public void RemoveFirst(T item)
        {
            var itemIndex = Array.IndexOf(this.elements, item);

            RemoveAtIndex(itemIndex);
        }

        public void RemoveAtIndex(int index)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException("There is no value at this index!");
            }

            for (int i = index; i < Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[Count - 1] = default(T);

            this.Count--;
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                this.elements[i] = default(T);
            }
        }

        public T ValueAtIndex(int index)
        {
            T result = this.elements[index];
            return result;
        }

        public override string ToString()
        {
            string result = string.Join(", ", this.elements);
            return result;
        }

        public T Min()
        {
            if (elements.Length == 0)
            {
                throw new Exception("The list is empty!");
            }

            if (elements.Length == 1)
            {
                return elements[0];
            }

            else
            {
                T min = elements[0];

                foreach (T item in elements)
                {
                    if (item.CompareTo(default(T)) == 0)
                    {
                        continue;
                    }
                    if (min.CompareTo(item) > 0)
                    {
                        min = item;
                    }
                }
                return min;
            }
        }

        public T Max()
        {
            if (elements.Length == 0)
            {
                throw new Exception("The list is empty!");
            }

            if (elements.Length == 1)
            {
                return elements[0];
            }

            else
            {
                T max = elements[0];

                foreach (T item in elements)
                {
                    
                    if (max.CompareTo(item) < 0)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

    }
}
