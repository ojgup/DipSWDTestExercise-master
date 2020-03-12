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

        [SetUp]
        public void Setup()
        {
            _driver = new FakeDriver();
            _passenger = new FakePassenger();
            _bus = new FakeBus(_driver, 100, 50, 2, 1);
        }

        [Test]
        public void checkConstructor()
        {
            Assert.AreEqual(,);
        }
    }
}
