using System;
using System.Collections.Generic;
using System.Text;
using DipTestingExercises;
namespace DipTestingExercisesTests
{
    class FakeBus : Bus
    {
        public FakeBus(IPerson pDriver, int pMaxFuel, int pCurrent, int pLitresPerKM, int pMaxPassengers) : base(pDriver, pMaxFuel, pCurrent, pLitresPerKM, pMaxPassengers)
        {
        }
    }
}
