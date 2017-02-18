using Academy.Core.Contracts;
using Academy.Commands.Adding;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Tests.Commands.Adding.Mocks;

namespace Academy.Tests.Commands.Adding.AddStudentsToCourseCommand
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenThePassedFactoryIsNull()
        {
            //Arrange
            var engineMock = new Mock<IEngine>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineMock.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenThePassedEngineIsNull()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(factoryMock.Object, null));
        }

        [Test]
        public void SetFactory_WhenThePassedFactoryIsNotNull()
        {
            //Arrange
            var engineMock = new Mock<IEngine>();
            var factoryMock = new Mock<IAcademyFactory>();

            //Act
            var command = new AddStudentToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            //Assert
            Assert.AreSame(factoryMock.Object, command.AcademyFactory);
        }

        [Test]
        public void SetEngine_WhenThePassedEngineIsNotNull()
        {
            //Arrange
            var engineMock = new Mock<IEngine>();
            var factoryMock = new Mock<IAcademyFactory>();

            //Act
            var command = new AddStudentToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            //Assert
            Assert.AreSame(engineMock.Object, command.Engine);
        }
    }
}
