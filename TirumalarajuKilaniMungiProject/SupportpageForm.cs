using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    public partial class SupportpageForm : Form
    {
        private static SupportpageForm supportpageFormInst = null;
        private SupportpageForm()
        {
            InitializeComponent();
            SupportMain supportMain = new SupportMain();
            supportLabel.Text = supportMain.GetSupport1();
        }

        public static SupportpageForm SupportpageSingletonForm()
        {
            if (supportpageFormInst == null)
            {
                supportpageFormInst = new SupportpageForm();
                return supportpageFormInst;
            }

            return supportpageFormInst;
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            supportpageFormInst = null;
        }

        private void emailSupportButton_Click(object sender, EventArgs e)
        {
            SupportDetailed supportDetailed = new SupportDetailed();
            supportLabel.Text = supportDetailed.GetSupport1();
        }

        private void phoneSupport_Click(object sender, EventArgs e)
        {
            SupportDetailed supportDetailed = new SupportDetailed();
            supportLabel.Text = supportDetailed.GetSupport2();

        }

        private void chatSupport_Click(object sender, EventArgs e)
        {
            SupportDetailed supportDetailed = new SupportDetailed();
            supportLabel.Text = supportDetailed.GetSupport2("run the overloaded method");

        }
    }
}
