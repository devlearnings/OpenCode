using Moq;
using Xunit;
using UnitTestDemo;

namespace UnitTestDemoTest
{
    public class BrPersonTest
    {
        [Fact]
        public void CanDrive_AgeLessThan18_ReturnsFalse()
        {
            //Arrange
            var person = new Mock<IPerson>();
            BrPerson brPerson = new BrPerson(person.Object);

            //Act
            person.Setup(x => x.GetPerson(It.IsAny<int>()))
                .Returns(new DtoPerson() { Age = 15, Id = 2, Name = "Test" });

            var canDrive = brPerson.CanDrive(It.IsAny<int>());

            //Assert
            Assert.Equal(false, canDrive);
        }

        [Fact]
        public void CanDrive_AgeMoreThan18_ReturnsTrue()
        {
            //Arrange
            var person = new Mock<IPerson>();
            BrPerson brPerson = new BrPerson(person.Object);

            //Act
            person.Setup(x => x.GetPerson(It.IsAny<int>()))
                .Returns(new DtoPerson() { Age = 25, Id = 2, Name = "Test" });

            var canDrive = brPerson.CanDrive(It.IsAny<int>());

            //Assert
            Assert.Equal(true, canDrive);
        }
    }
}
