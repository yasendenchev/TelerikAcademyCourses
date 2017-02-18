using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TravelServiceTest
    {
        private TravelService travelService;

        [SetUp]
        public void SetUp()
        {
            travelService = new TravelService();
        }

        [TearDown]
        public void TearDown()
        {
            travelService = null;
        }

        public void BookTrip_shouldBookSuccessfully()
        {
            travelService.BookTrip("234", "234");
        }

        public void BookTrip_shouldFailWhileBooking()
        {
            travelService.BookTrip(null, null);
        }
    }
}
