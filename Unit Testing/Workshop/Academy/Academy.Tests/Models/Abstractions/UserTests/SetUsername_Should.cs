using Academy.Tests.Models.Abstractions.Mocks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.Abstractions.UserTests
{
    [TestFixture]
    public class SetUsername_Should
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("Mu")]
        [TestCase("This is a name that is supposed to be longer than 16 characters")]
        public void ThrowArgumenException_WhenPassedValueIsInvalid(string username)
        {
            //Arrange
            var sut = new UserMock("Pesho");

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Username = username);
        }

        [Test]
        public void NotThrow_WhenPassedValueIsValid()
        {
            //Arrange
            var sut = new UserMock("Pesho");

            //Act & Assert
            Assert.DoesNotThrow(() => sut.Username = "Ivanka");
        }

        [Test]
        public void AssignUsername_WhenItIsValid()
        {
            //Arrange
            var sut = new UserMock("Pesho");

            //Act
            string result = "Ivan";
            sut.Username = result;

            //Assert
            Assert.AreEqual(result, sut.Username);
        }
    }
}
