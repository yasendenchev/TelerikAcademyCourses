using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;

namespace Academy.Tests.Models
{
    [TestFixture]
    class GetName_Should
    {
        [Test]
        public void ReturnTheProperNameValue_WhenGetMethodIsCalled()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act
            var result = sut.Name;

            //Assert
            Assert.AreEqual(result, "Valid name");
        }
    }
}
