using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    public class ToString_Should
    {
        [Test]
        public void IterateOverLecturesCollection_WhenTheCollectionIsNotEmpty()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            var lectureMock = new Mock<ILecture>();

            lectureMock.Setup(x => x.ToString());

            sut.Lectures.Add(lectureMock.Object);

            //Act
            sut.ToString();

            //Assert
            lectureMock.Verify(x => x.ToString(), Times.Once);
        }

        [Test]
        public void AddMessageToEndResult_WhenTheCollectionIsEmpty()
        {
            //Arrange
            var sut = new Course("Valid name", 3, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));
            
            //Act
            sut.ToString();

            //Assert
            StringAssert.Contains("no lectures", sut.ToString());
        }
    }
}
