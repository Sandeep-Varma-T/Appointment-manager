using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirumalarajuKilaniMungiProject
{
    //Created by TirumalarajuKilaniMungi
    //This is Doctors Class which extends from Users class
    internal class Doctors : Users
    {
        string specilization { get; set; }
        string clinicName { get; set; }
        string clinicAddress { get; set; }
        string pinCode { get; set; }

    }//class
}//namespace
