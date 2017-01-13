using System;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
        where T: IComparable
    {
        
        private T begin;
        private T end;
        private const string msg = "The value must be withing the given range!";

        public InvalidRangeException(T begin, T end) : base(msg)
        {
            this.Begin = begin;
            this.End = end;
        }

        public T Begin
        {
            get
            {
                return this.begin;
            }
            set
            {
                this.begin = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }

        public string Msg
        {
            get
            {
                return msg;
            }
        }

        public static void CheckRange(T begin, T end, T checkValue)
        {
           try
            {
                if (checkValue.CompareTo(begin) < 0 || checkValue.CompareTo(end) > 0)
                {
                    throw new InvalidRangeException<T>(begin, end);
                }
                Console.WriteLine("Value {0} is withing range.", checkValue);
                Console.WriteLine();
            }
            catch (InvalidRangeException<T> e)
            {
                Console.WriteLine("ERROR!");
                Console.WriteLine(e.Msg);
                Console.WriteLine();
            }
        }
    }
}
