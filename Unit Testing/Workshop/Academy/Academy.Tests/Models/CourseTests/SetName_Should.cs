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
    public class SetName_Should
    {
        [TestCase("Lg")]
        [TestCase("Too long long long long long long long long long long long long long long long long long long name")]
        [TestCase(null)]
        public void ThrowArgumentException_WhenPassedValueIsInvalid(string name)
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Assert
            Assert.Throws<ArgumentException>(() => sut.Name = name);
        }

        [Test]
        public void NotThrow_WhenPassedValueIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.DoesNotThrow(() => sut.Name = "New Valid Name");
        }

        [Test]
        public void AssignName_WhenItIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act
            string name = "Pencho";
            sut.Name = name;

            //Act &&
            Assert.AreEqual(sut.Name, name);
        }
    }
}
