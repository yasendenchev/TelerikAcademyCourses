using Academy.Core.Contracts;
using Academy.Tests.Commands.Adding.Mocks;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Commands.Adding.AddStudentToCourseCommandTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedAcademyFactoryIsNull()
        {
            //Arrange
            var engineMock = new Mock<IEngine>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToCourseCommandMock(null, engineMock.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenPassedEngineIsNull()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToCourseCommandMock(factoryMock.Object, null));
        }

        [Test]
        public void AssignFactoryValue_WhenPassedValuesAreCorrect()
        {
            //Arrange
            var engineMock = new Mock<IEngine>();
            var factoryMock = new Mock<IAcademyFactory>();

            //Act
            var command = new AddStudentToCourseCommandMock(factoryMock.Object, engineMock.Object);

            //Assert
            Assert.AreSame(factoryMock.Object, command.AcademyFactory);
        }

        [Test]
        public void AssignEngineValue_WhenPassedValuesAreCorrect()
        {
            //Arrange
            var engineMock = new Mock<IEngine>();
            var factoryMock = new Mock<IAcademyFactory>();

            //Act
            var command = new AddStudentToCourseCommandMock(factoryMock.Object, engineMock.Object);

            //Assert
            Assert.AreSame(engineMock.Object, command.Engine);
        }
    }
}
