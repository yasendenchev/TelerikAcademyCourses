using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Academy.Commands.Adding;
using NUnit.Framework;
using Academy.Models.Contracts;
using Academy.Core.Contracts;
using Academy.Models;

namespace Academy.Tests.Commands.Adding.AddStudentToCourseCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void ThrowArgumentException_WhenPassedCourseIsInvalid()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();
            var courseMock = new Mock<ICourse>();

            studentMock.SetupGet(x => x.Username).Returns("Pesho");
            engineMock.SetupGet(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.SetupGet(x => x.Courses).Returns(new List<ICourse>() { courseMock.Object });

            var command = new AddStudentToCourseCommand(factoryMock.Object, engineMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => command.Execute(new List<string>() { "Pesho", "0", "0", "something" }));
        }

        [Test]
        public void AddStudentToCourse_WhenPassedValuesAreCorrect()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();
            var courseMock = new Mock<ICourse>();

            studentMock.SetupGet(x => x.Username).Returns("Pesho");
            engineMock.SetupGet(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.SetupGet(x => x.Courses).Returns(new List<ICourse>() { courseMock.Object });
            courseMock.SetupGet(x => x.OnsiteStudents).Returns(new List<IStudent>());

            var command = new AddStudentToCourseCommand(factoryMock.Object, engineMock.Object);

            //Act
            command.Execute(new List<string>() { "Pesho", "0", "0", "onsite" });

            //Assert
            Assert.AreSame(studentMock.Object.Username, courseMock.Object.OnsiteStudents[0].Username);
        }

        [Test]
        public void ReturnMessage_WhenSTudentIsAddedToCourse()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();
            var courseMock = new Mock<ICourse>();

            studentMock.SetupGet(x => x.Username).Returns("Pesho");
            engineMock.SetupGet(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.SetupGet(x => x.Courses).Returns(new List<ICourse>() { courseMock.Object });
            courseMock.SetupGet(x => x.OnsiteStudents).Returns(new List<IStudent>());

            var command = new AddStudentToCourseCommand(factoryMock.Object, engineMock.Object);

            //Act
            var result = command.Execute(new List<string>() { "Pesho", "0", "0", "onsite" });

            //Assert
            StringAssert.Contains("Student Pesho", result);
            StringAssert.Contains("Course 0", result);
        }
    }
}
