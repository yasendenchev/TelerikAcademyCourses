using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.Seasontests
{
    [TestFixture]
    public class ListCourses_Should
    {
        [Test]
        public void IterateOverCoursesCollection_WhenItIsNotEmpty()
        {
            //Arrange 
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);

            var courseMock = new Mock<ICourse>();

            sut.Courses.Add(courseMock.Object);

            courseMock.Setup(x => x.ToString());

            //Act
            sut.ListCourses();

            //Assert
            courseMock.Verify(x => x.ToString(), Times.Once);

        }

        [Test]
        public void AddMessageToResult_WhenCollectionIsEmpty()
        {
            //Arrange
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);

            //Act & Assert
            StringAssert.Contains("no courses", sut.ListCourses());
        }
    }
}
