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
    public class Course_Should
    {
        public Course GenerateCourse()
        {
            return new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));
        }

        [Test]
        public void SetProperName_WhenObjectIsConstructed()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.AreEqual("Valid name", sut.Name);
        }

        [Test]
        public void SetProperLecturesPerWeek_WhenObjectIsConstructed()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.AreEqual(3, sut.LecturesPerWeek);
        }

        [Test]
        public void SetProperStartingDate_WhenObjectIsConstructed()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.AreEqual(new DateTime(2017, 02, 10), sut.StartingDate);
        }

        [Test]
        public void SetProperEndingDate_WhenObjectIsConstructed()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.AreEqual(new DateTime(2017, 03, 10), sut.EndingDate);
        }

        [Test]
        public void InitializeLecturesCollection()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.IsNotNull(sut.Lectures);
        }

        [Test]
        public void InitializeOnlineStudentsCollection()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.IsNotNull(sut.OnlineStudents);
        }

        [Test]
        public void InitializeOnsiteStudentsCollection()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            //Act & Assert
            Assert.IsNotNull(sut.OnsiteStudents);
        }
    }
}
