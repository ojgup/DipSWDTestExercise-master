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
    }
}