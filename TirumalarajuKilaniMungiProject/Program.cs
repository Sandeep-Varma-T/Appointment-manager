using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirumalarajuKilaniMungiProject
{
    //declaring enums for slot day and slot times

    enum SlotDays
    {
        Monday      = 1,
        Tuesday     = 2,
        Wednesday   = 3,
        Thursday    = 4,
        Friday      = 5,
        Saturday    = 6,
        Sunday      = 7
    }//SlotDays

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DrConsult());
        }
    }
}
