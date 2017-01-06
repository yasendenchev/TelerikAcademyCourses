using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class GenericList<T>
    {
        private T[] elements;
        private int capacity;

        public int Count { get; private set; }

        public GenericList(int capacity)
        {
            this.Count = 0;
            this.elements = new T[capacity];
            this.capacity = capacity;
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

        //[1, 4, 6 , 7, 8] c = 5  i = 1

        public void Add(T item)
        {
            if (this.Count == this.Capacity)
            {
                this.Expand();
            }
            elements[this.Count] = item;
            this.Count++;
        }

        public void RemoveFirst(T item)
        {
            var itemIndex = Array.IndexOf(this.elements, item);

            for (int i = itemIndex; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);

            this.Count--;
        }

        public override string ToString()
        {
            string result = string.Join(", ", this.elements);
            return result;
        }

        private void Expand()
        {

            T[] newArray = new T[2 * this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
        }
    }
}
