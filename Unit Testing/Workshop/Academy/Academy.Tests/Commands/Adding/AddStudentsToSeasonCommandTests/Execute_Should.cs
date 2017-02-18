using Academy.Commands.Adding;
using Academy.Core.Contracts;
using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Commands.Adding.AddStudentsToCourseCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void ThrowArgumentException_WhenStudentIsAlreadyInTheSeason()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();

            studentMock.Setup(x => x.Username).Returns("Pesho");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => command.Execute(new List<string> { "Pesho", "0" }));
        }

        [Test]
        public void AddStudentToCollection_WhenItIsNotInTheSeason()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var secondStudentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();
            var studentsInSeason = new List<IStudent>() { secondStudentMock.Object };

            studentMock.Setup(x => x.Username).Returns("Pesho");
            secondStudentMock.Setup(x => x.Username).Returns("Peshka");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.Setup(x => x.Students).Returns(studentsInSeason);

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);

            //Act
            var result = command.Execute(new List<string>() { "Pesho", "0" });

            //Assert
            Assert.AreEqual(2, seasonMock.Object.Students.Count);
        }

        [Test]
        public void ReturnMessage_WhenAStudentIsAddedInSeason()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var secondStudentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();
            var studentsInSeason = new List<IStudent>() { secondStudentMock.Object };

            studentMock.Setup(x => x.Username).Returns("Pesho");
            secondStudentMock.Setup(x => x.Username).Returns("Peshka");
            engineMock.Setup(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });
            engineMock.Setup(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });
            seasonMock.Setup(x => x.Students).Returns(studentsInSeason);

            var command = new AddStudentToSeasonCommand(factoryMock.Object, engineMock.Object);

            //Act
            var result = command.Execute(new List<string>() { "Pesho", "0" });

            //Assert
            StringAssert.Contains("Student Pesho", result);
            StringAssert.Contains("Season 0", result);
        }
    }
}
