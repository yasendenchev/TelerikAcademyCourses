using System;

namespace RangeExceptions
{
    class Startup
    {
        static void Main(string[] args)
        {
            var exc = new InvalidRangeException<int>(1, 100);
            InvalidRangeException<int>.CheckRange(exc.Begin, exc.End, 99);

            var dateExc = new InvalidRangeException<DateTime>(new DateTime(1980,1,1), new DateTime(2013,12,31));
            InvalidRangeException<DateTime>.CheckRange(dateExc.Begin, dateExc.End, new DateTime(1998, 12, 31));
        }
    }
}
