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
    public class SetEndingDate_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedValueIsInvalid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.EndingDate = null);
        }

        [Test]
        public void NotThrow_WhenPassedValueIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.DoesNotThrow(() => sut.EndingDate = new DateTime(2017, 03, 09));
        }

        [Test]
        public void AssignEndingDateValue_WhenItIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act 
            var result = new DateTime(2017, 03, 09);
            sut.EndingDate = result;

            //Assert
            Assert.AreEqual(result, sut.EndingDate);
        }
    }
}
