using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TravelService
    {
        // returns duration in days
        public int BookTrip(string userId, string tripId)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(tripId))
            {
                throw new ArgumentException();
            }
            return 5;
        }
    }
}
