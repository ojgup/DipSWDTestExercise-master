using System;
using System.Collections.Generic;
using System.Text;
using DipTestingExercises;

namespace DipTestingExercisesTests
{
    class FakePassenger : Passenger
    {
        public FakePassenger(string pFname, string pLname, string pGender, string pTicketType) : base(pFname, pLname, pGender, pTicketType)
        {
        }
    }
}
