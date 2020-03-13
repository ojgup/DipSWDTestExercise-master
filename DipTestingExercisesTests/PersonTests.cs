using NUnit.Framework;
using DipTestingExercises;
using System;

namespace DipTestingExercisesTests
{
    class PersonTests
    {
        FakePerson _fakeperson;
        [SetUp]
        public void Setup()
        {
            _fakeperson = new FakePerson("Ojas", "Gupta", "M");
        }

        [Test]
        public void checkConstructor()
        {
            Assert.AreEqual("Ojas", _fakeperson.fname);
            Assert.AreEqual("Gupta", _fakeperson.lname);
            Assert.AreEqual("M", _fakeperson.getGender());
        }

        [Test]
        public void getName()
        {
            Assert.AreEqual("Ojas Gupta", _fakeperson.getName());
        }

        [Test]
        public void getGender()
        {
            Assert.AreEqual("M", _fakeperson.getGender());
        }

        [Test]
        [Ignore("Test_To_Ignore")]
        public void Test_To_Ignore()
        {

        }
    }
}
