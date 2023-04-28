using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    internal class SupportDetailed:SupportMain
    {

        public override string GetSupport1()
        {
            return "Please contact the below email for support : \n\n drconsult@gmail.com";
        }

        public string GetSupport2()
        {
            return "Please contact the below phone number for support : \n\n +1 9137112698";
        }

        public string GetSupport2(string toOverload)
        {
            return "Currently our executives are busy, please visit again to continue with chat support";
        }

    }
}
