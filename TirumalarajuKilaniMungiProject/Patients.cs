using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    //This is patient class which extends from Users class
    internal class Patients : Users
    {
              
        public string GenerateRandomIdForPatient()
        {
            Random rnd = new Random();
            int patRandId = rnd.Next(10000000, 99999999);
            return ("PAT" + patRandId);
        }


    }//class
}//namespace
