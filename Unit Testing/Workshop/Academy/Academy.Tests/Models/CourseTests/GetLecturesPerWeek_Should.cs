using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models
{
    [TestFixture]
    public class GetLecturesPerWeek_Should
    {
        [Test]
        public void ReturnTheProperLecturesPerWeekValue_WhenGetMethodIsCalled()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act
            var result = sut.Name;

            //Assert
            Assert.AreEqual(result, sut.Name);
        }
    }
}
