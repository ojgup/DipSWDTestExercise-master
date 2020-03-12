using System;
using System.Collections.Generic;
using System.Text;
using DipTestingExercises;

namespace DipTestingExercisesTests
{
    class FakePassenger : IPerson
    {
        public string getGender()
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            throw new NotImplementedException();
        }
    }
}
