using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    internal class SupportMain:SupportAbstractClass
    {

        public override string GetSupport()
        {
            return "null";
        }

        public virtual string GetSupport1() {
            return "Welcome to Dr.Consult Support page. Click on email or phone or chat support to get assistance";
        }

    }
}
