using Academy.Models;
using Academy.Models.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Academy.Models.Contracts;

namespace Academy.Tests.Models.Seasontests
{
    [TestFixture]
    class ListUsers_Should
    {
        [Test]
        public void IterateOverUCollection_WhenItContainsAStudent()
        {
            //Arrange
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);

            var studentMock = new Mock<IStudent>();

            studentMock.Setup(x => x.ToString());

            sut.Students.Add(studentMock.Object);

            //Act
            sut.ListUsers();

            //Assert
            studentMock.Verify(x => x.ToString(), Times.Once);
        }

        [Test]
        public void IterateOverCollection_WhenItContainsATrainer()
        {
            //Arrange
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);

            var trainerMock = new Mock<ITrainer>();

            trainerMock.Setup(x => x.ToString());

            sut.Trainers.Add(trainerMock.Object);

            //Act
            sut.ListUsers();

            //Assert
            trainerMock.Verify(x => x.ToString(), Times.Once);
        }

        [Test]
        public void AddMessageToResult_WhenCollectionIsEmpty()
        {
            //Arrange
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);
            
            //Act & Assert
            StringAssert.Contains("no users", sut.ListUsers());
        }

    }
}
