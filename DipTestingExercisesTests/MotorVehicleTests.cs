using NUnit.Framework;
using DipTestingExercises;
using System;

namespace DipTestingExercisesTests
{
    public class MotorVehicleTests
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

        [TestCase(50)]
        public void Refuel_AppropriateFuelAdded_AddsFuel(int fuel)
        {
            FakeMotorVehicle.refuel(fuel);
            Assert.AreEqual(100, FakeMotorVehicle.currentFuel);
        }

        [TestCase(-1)]
        public void Refuel_NegativeFuelAdded_RaisesException(int fuel)
        {
            try
            {
                FakeMotorVehicle.refuel(fuel);
            } catch(Exception ex)
            {
                Assert.AreEqual("Someone is stealing fuel!!", ex.Message);
            }
        }

        [TestCase(51)]
        public void Refuel_TooMuchFuelAdded_RaisesException(int fuel)
        {
            try
            {
                FakeMotorVehicle.refuel(fuel);
            } catch(Exception ex)
            {
                Assert.AreEqual("Vehicle cannot hold that much fuel!", ex.Message);
            }
        }

        [TestCase(10)]
        public void Travel_HasEnoughFuel_AdjustsCurrentFuel(int travelDistance)
        {
            FakeMotorVehicle.travel(travelDistance);
            Assert.AreEqual(30, FakeMotorVehicle.getFuelRemaining());
        }

        [TestCase(26)]
        public void Travel_RunsOutOfFuel_RaisesExceptionAndFuelSetToZero(int travelDistance)
        {
            try
            {
                FakeMotorVehicle.travel(travelDistance);

            } catch(Exception ex)
            {
                Assert.AreEqual("Out of Fuel!", ex.Message);
            }
        }
    }
}