using NUnit.Framework;
using DipTestingExercises;
using System;

namespace DipTestingExercisesTests
{
    class BusTests
    {
        Bus _bus;
        FakeDriver _driver;
        FakePassenger _passenger;
        FakePassenger _passenger2;

        [SetUp]
        public void Setup()
        {
            _driver = new FakeDriver();
            _passenger = new FakePassenger();
            _passenger2 = new FakePassenger();
            _bus = new FakeBus(_driver, 100, 50, 2, 1);
        }

        [Test]
        public void checkConstructor()
        {
            Assert.AreEqual(1,_bus.maxPassengers);
        }

        [Test]
        public void getPassengerCount()
        {
            Assert.AreEqual(0, _bus.getPassengerCount());
        }

        [Test]
        public void getPassengerCount_WithPassenger()
        {
            _bus.passengers.Add(_passenger);
            Assert.AreEqual(1, _bus.getPassengerCount());

        }

        [Test]
        public void embarkPassenger()
        {
            _bus.embarkPassenger(_passenger);
            Assert.AreEqual(_passenger, _bus.passengers[0]);
        }

        [Test]
        public void embarkPassenger_BusIsFull()
        {
            try
            {
                _bus.embarkPassenger(_passenger);
                _bus.embarkPassenger(new FakePassenger());
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.AreEqual(1, _bus.getPassengerCount());

                Assert.IsTrue(ex.Message.Contains("Bus"));
                Assert.IsTrue(ex.Message.Contains("Full"));
            }

        }
    }
}
