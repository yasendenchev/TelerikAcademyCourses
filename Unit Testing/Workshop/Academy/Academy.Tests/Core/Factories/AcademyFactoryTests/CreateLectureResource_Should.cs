using Academy.Core.Factories;
using Academy.Models.Utils.LectureResources;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Core.Factories
{
    [TestFixture]
    public class CreateLectureResource_Should
    {
        [Test]
        public void ReturnVideoResource_WhenVideoTypeIsPassed()
        {
            //Arrange
            var factory = AcademyFactory.Instance;

            //Act
            var resource = factory.CreateLectureResource("video", "pesho", "ivan.com");

            //Assert
            Assert.IsInstanceOf<VideoResource>(resource);
        }

        [Test]
        public void ReturnPresentationResource_WhenPresentationTypeIsPassed()
        {
            //Arrange
            var factory = AcademyFactory.Instance;

            //Act
            var resource = factory.CreateLectureResource("presentation", "pesho", "ivan.com");

            //Assert
            Assert.IsInstanceOf<PresentationResource>(resource);
        }

        [Test]
        public void ReturnDemoResource_WhenDemoTypeIsPassed()
        {
            //Arrange
            var factory = AcademyFactory.Instance;

            //Act
            var resource = factory.CreateLectureResource("demo", "pesho", "ivan.com");

            //Assert
            Assert.IsInstanceOf<DemoResource>(resource);
        }

        [Test]
        public void ReturnHomeworkResource_WhenHomeworkTypeIsPassed()
        {
            //Arrange
            var factory = AcademyFactory.Instance;

            //Act
            var resource = factory.CreateLectureResource("homework", "pesho", "ivan.com");

            //Assert
            Assert.IsInstanceOf<HomeworkResource>(resource);
        }

        [Test]
        public void ThrowArgumentException_WhenInvalidTypeIsPassed()
        {
            //Arrange
            var factory = AcademyFactory.Instance;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateLectureResource("pesho", "pesho", "ivan.com"));
            
        }

        [TestCase("lg")]
        [TestCase("This string should be longer than 16 chars")]
        public void ThrowArgumentException_WhenInvalidNameIsPassed(string name)
        {
            //Arrange
            var factory = AcademyFactory.Instance;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateLectureResource("pesho", name, "ivan.com"));

        }

        [TestCase("lg")]
        [TestCase("Long long long Long long long Long long long Long long long Long long long Long longlong")]
        public void ThrowArgumentException_WhenInvalidUrlIsPassed(string url)
        {
            //Arrange
            var factory = AcademyFactory.Instance;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateLectureResource("pesho", "pesho", url));

        }
    }
}
