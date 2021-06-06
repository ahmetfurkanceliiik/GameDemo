using System;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;

        }
    }
}
