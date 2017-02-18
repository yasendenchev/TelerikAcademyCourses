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
    public class SetLecturesPerWeek_Should
    {
        [TestCase(0)]
        [TestCase(8)]
        public void ThrowArgumentException_WhenPassedValueIsInvalid(int number)
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.LecturesPerWeek = number);
        }

        [Test]
        public void NotThrow_WhenPassedValueIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.DoesNotThrow(() => sut.LecturesPerWeek = 7);
        }

        [Test]
        public void AssignLecturesPerWeekValue_WhenItIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            // Act
            int number = 5;
            sut.LecturesPerWeek = number;

            //Assert
            Assert.AreEqual(number, sut.LecturesPerWeek);
        }
    }
}
