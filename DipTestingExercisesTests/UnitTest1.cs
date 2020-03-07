using NUnit.Framework;
using DipTestingExercises;
namespace DipTestingExercisesTests
{
    public class Tests
    {
        

        FakeMotorVehicle FakeMotorVehicle;
        FakeDriver fakeDriver;
        [SetUp]
        public void Setup()
        {
            FakeMotorVehicle = new FakeMotorVehicle(fakeDriver, 100, 50, 2);
        }

        [Test]
        public void checkConstructor()
        {
            Assert.AreEqual(100, FakeMotorVehicle.maxFuel);
            Assert.AreEqual(50, FakeMotorVehicle.currentFuel);
            Assert.AreEqual(2, FakeMotorVehicle.litresPerKM);
        }

        [Test]
        public void getFuelRemaining()
        {
            // Act 
            int fuelRemaining = FakeMotorVehicle.getFuelRemaining();
            // Assert 
            Assert.AreEqual(50, fuelRemaining);
        }

        [Test]
        [TestCase(50)]
        [TestCase(51)]
        [TestCase()]
        public void refuel(int fuel, )
        {
            //Arrange

            //Act
            FakeMotorVehicle.refuel(fuel);
            //Assert
            Assert.AreEqual(100, FakeMotorVehicle.currentFuel);
            Assert.AreEqual()
        }
    }
}