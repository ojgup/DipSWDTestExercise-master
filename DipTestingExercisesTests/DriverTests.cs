using NUnit.Framework;
using DipTestingExercises;
using System;

namespace DipTestingExercisesTests
{
    class DriverTests
    {
        Driver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new Driver("Bill", "Hamilton", "M", "GFD433");
        }

        [Test]
        public void checkConstructor()
        {

        }
    }
}
