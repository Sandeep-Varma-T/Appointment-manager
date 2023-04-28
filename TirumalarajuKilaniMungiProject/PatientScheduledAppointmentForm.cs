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
    public partial class PatientScheduledAppointmentForm : Form
    {
        private DrConsult mdiInst;
        private PatientViewAppointmentForm patientViewAppointmentFormInst;
        private DataSet ds;
        private DrConsultIntermediary intermediary = new DrConsultIntermediary();
        string totalBill = null;
        string appointmentId;
        private string patientId;
        private string doctorId;
        string slotId;
        string userType;
        public PatientScheduledAppointmentForm(DrConsult mdiInst,DataSet ds,PatientViewAppointmentForm patientViewAppointmentFormInst)
        {
            InitializeComponent();
            this.mdiInst = mdiInst;
            this.ds = ds;
            this.patientViewAppointmentFormInst = patientViewAppointmentFormInst;
        }



        private void prescriptionButton_Click(object sender, EventArgs e)
        {

            DataSet ds = intermediary.getPrescription(patientId,doctorId);
            if (ds.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("Currently there is no prescription added", "prescription");

            }
            else
            {
                PrescriptionForm prescriptionForm = new PrescriptionForm(ds,this);
                prescriptionForm.MdiParent = mdiInst;
                prescriptionForm.Show();
            }
            
        }

        private void OnLoad(object sender, EventArgs e)
        {

            DataRow row = ds.Tables[0].Rows[0];
            appointmentId = row[0].ToString();
            appointmentIdLabel.Text = appointmentId;
            appointmentDateLabel.Text = row[1].ToString().Substring(0,10);
            DateTime appDate = DateTime.Parse(row[1].ToString().Substring(0, 10));
            DateTime dateToday = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
            double days = (appDate - dateToday).TotalDays;
            if (row[2].ToString() == "null")
            {
                appointmentTimeLabel.Text = "Your Emergency appointment is not yet approved by doctor";

            }
            else
            {
                appointmentTimeLabel.Text = row[2].ToString();
            }
            issueDescriptionTextBox.Text = row[3].ToString();
            patientFirstNameLabel.Text = row[4].ToString();
            patientLastNameLabel.Text = row[5].ToString();
            doctorFirstNameLabel.Text = row[6].ToString();
            doctorLastNameLabel.Text = row[7].ToString();
            clinicAddressLabel.Text = row[8].ToString();
            if (row[9].ToString() == "REG")
            {
                userType = "REG";
                appointmentTypeLabel.Text = "Regular Appointment";
            }
            else
            {
                userType = "EME";
                if(row[2].ToString() == "null")
                {
                    appointmentTypeLabel.Text = "Emergency Appointment. Not Accepted yet.";
                }
                else
                {
                    appointmentTypeLabel.Text = "Emergency Appointment. Accepted.";
                }
            }
            if (days > 1.0)
            {
                cancelAppointmentButton.Enabled = true;
            }
            else
            {
                cancelAppointmentButton.Enabled = false;
            }
            totalBill = row[10].ToString();
            slotId = row[11].ToString();
            patientId = row[12].ToString();
            doctorId = row[13].ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            patientViewAppointmentFormInst.Visible = true;
        }

        private void totalBillButton_Click(object sender, EventArgs e)
        {
            if(totalBill == "0")
            {
                MessageBox.Show("Bill is not yet generated for your case.", "Bill"); 
            }
            else
            {
                MessageBox.Show($"Your bill is :- {totalBill}");
            }
        }

        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Click Yes to Cancel the appointment", "Cancel Appointment",MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {

                int isCancelled = intermediary.cancelAppointment(appointmentId,slotId,userType);
                if(isCancelled > 0)
                {
                    MessageBox.Show("Appoinment Cancelled");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to cancel the appointment");
                }
                
                
            }

        }
    }
}
