using NUnit.Framework;
using DipTestingExercises;
using System;

namespace DipTestingExercisesTests
{
    class BusTests
    {
        FakeBus FakeBus;
        FakeDriver FakeDriver;

        [SetUp]
        public void Setup()
        {
            FakeBus = new FakeBus(FakeDriver, 100, 50, 2, 1);
        }
    }
}
