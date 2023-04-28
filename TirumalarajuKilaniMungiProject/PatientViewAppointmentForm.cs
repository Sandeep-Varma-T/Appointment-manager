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
    public partial class PatientViewAppointmentForm : Form
    {
        private static PatientViewAppointmentForm patientViewAppointmentFormInst = null;
        private DrConsult mdiInst;
        private DrConsultIntermediary intermediary = new DrConsultIntermediary();
       private PatientViewAppointmentForm(DrConsult mdiInst)
        {
            InitializeComponent();
            this.mdiInst = mdiInst;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            appointmentErrorProvider.Clear();
            firstNameerrorProvider.Clear();
            if (appointmentIDTextBox.Text.Length < 1)
            {
                appointmentErrorProvider.SetError(appointmentIDTextBox, "Please enter appointment ID");
            }
            else if (firstNameTextBox.Text.Length < 1)
            {
                firstNameerrorProvider.SetError(firstNameTextBox, "Please enter your first name");
            }
            else
            {
                string appointmentId = appointmentIDTextBox.Text;
                string firstName = firstNameTextBox.Text;
                int validation = intermediary.ValidatePatient(appointmentId, firstName);

                if (validation == 1)
                {

                    DataSet ds = intermediary.getAppointmentDetails(appointmentId);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("The appointment has been cancelled!!","Appointment Cancelled");
                    }
                    else
                    {
                        PatientScheduledAppointmentForm scheduledAppointmentForm = new PatientScheduledAppointmentForm(mdiInst, ds, this);

                        scheduledAppointmentForm.MdiParent = mdiInst;
                        scheduledAppointmentForm.Show();
                        appointmentIDTextBox.Text = "";
                        firstNameTextBox.Text = "";
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid details for appointment Id and first name");
                    appointmentIDTextBox.Text = "";
                    firstNameTextBox.Text = "";

                }

            }

        }

        public static PatientViewAppointmentForm patientViewAppointmentSingletonForm(DrConsult mdiInst)
        {
            if (patientViewAppointmentFormInst == null)
            {
                patientViewAppointmentFormInst = new PatientViewAppointmentForm(mdiInst);
                return patientViewAppointmentFormInst;
            }

            return patientViewAppointmentFormInst;
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            patientViewAppointmentFormInst = null;
        }

        private void clearContentsButton_Click(object sender, EventArgs e)
        {
            appointmentIDTextBox.Text = "";
            firstNameTextBox.Text = "";
        }

        private void OnLoad(object sender, EventArgs e)
        {
            appointmentIDTextBox.Text = "";
            firstNameTextBox.Text = "";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
