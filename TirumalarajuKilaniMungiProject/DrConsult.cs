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
    public partial class DrConsult : Form
    {
        public static List<String> slotTimes;
        public static List<String> slotDay;

        public DrConsult()
        {
            InitializeComponent();
            slotTimes = new List<String>();
            slotDay = new List<String>();
            slotTimes.Add("PlaceHolder");
            slotTimes.Add("09:00 AM - 10:00 AM");
            slotTimes.Add("10:00 AM - 11:00 AM");
            slotTimes.Add("01:00 PM - 02:00 PM");
            slotTimes.Add("02:00 PM - 03:00 PM");
            slotTimes.Add("03:00 PM - 04:00 PM");
            slotTimes.Add("06:00 PM - 07:00 PM");
            slotDay.Add("PlaceHolder");
            slotDay.Add("Monday");
            slotDay.Add("Tuesday");
            slotDay.Add("Wednesday");
            slotDay.Add("Thursday");
            slotDay.Add("Friday");
            slotDay.Add("Saturday");
            slotDay.Add("Sunday");

        }

        private void scheduleAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForAppointmentForm searchAppointment;
            searchAppointment = SearchForAppointmentForm.SingletonSearchForAppointmentForm(this);
            searchAppointment.MdiParent = this;
            searchAppointment.Show();
        }

        private void viewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientViewAppointmentForm viewAppointment = PatientViewAppointmentForm.patientViewAppointmentSingletonForm(this);
            viewAppointment.MdiParent = this;
            viewAppointment.Show();
        }

        private void viewAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoctorViewApppointmentsForm doctorViewApppointmentsForm = DoctorViewApppointmentsForm.DoctorViewApppointmentsSingletonForm(this);
            doctorViewApppointmentsForm.MdiParent = this;
            doctorViewApppointmentsForm.Show();
        }


        private void supportPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupportpageForm supportpageForm = SupportpageForm.SupportpageSingletonForm();
            supportpageForm.MdiParent = this;
            supportpageForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = AboutBox1.sigletonAboutBox();
            aboutBox1.MdiParent = this;
            aboutBox1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
