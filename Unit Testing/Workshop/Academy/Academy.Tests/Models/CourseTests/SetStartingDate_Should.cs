﻿using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models
{
    [TestFixture]
    public class SetStartingDate_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedValueIsNull()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.StartingDate = null);
        }

        [Test]
        public void NotThrow_WhenPassedValueIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.DoesNotThrow(() => sut.StartingDate = new DateTime(2017, 02, 11));
            
        }

        [Test]
        public void AssignStartingDateValue_WhenItIsValid()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act
            var result = new DateTime(2017, 02, 11);
            sut.StartingDate = result;

            //Assert
            Assert.AreEqual(result, sut.StartingDate);
        }
    }
}
