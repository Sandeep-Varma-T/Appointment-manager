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
    public partial class DoctorScheduledAppointmentsForm : Form
    {
        private DrConsult mdiInst;
        private DataSet ds;
        private DrConsultIntermediary intermediary = new DrConsultIntermediary();
        public DoctorScheduledAppointmentsForm(DrConsult mdiInst,DataSet ds)
        {
            InitializeComponent();
            this.mdiInst = mdiInst;
            this.ds = ds;
        }

        private void writePrescriptionButton_Click(object sender, EventArgs e)
        {

            DoctorScheduledAppointmentsForm inst = this;
            this.Visible = false;
            DoctorAddPrescriptionForm doctorAddPrescriptionForm = new DoctorAddPrescriptionForm(this,doctorIDLabel.Text,patientIDLabel.Text);
            doctorAddPrescriptionForm.MdiParent = mdiInst;
            doctorAddPrescriptionForm.Show();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DataTable patientsData = ds.Tables[0];
            BindingSource patientBindingSource = new BindingSource();
            patientBindingSource.DataSource = patientsData;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = patientBindingSource;
            String appDate = dataGridView1.CurrentRow.Cells[13].Value.ToString().Substring(0,9);
            dataGridView1.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[13].Visible = true;
            dataGridView1.Columns[15].Visible = true;
            dataGridView1.Columns[16].Visible = true;
            patientFirstNameLabel.DataBindings.Add("Text", patientBindingSource, "FirstName", false, DataSourceUpdateMode.Never);
            patientLastNameLabel.DataBindings.Add("Text", patientBindingSource, "LastName", false, DataSourceUpdateMode.Never);
            appointmentDayLabel.DataBindings.Add("Text", patientBindingSource, "AppointmentDay", false, DataSourceUpdateMode.Never);
            appointmentTimeLabel.DataBindings.Add("Text", patientBindingSource, "AppointmentTime", false, DataSourceUpdateMode.Never);
            briefDescriptionTextBox.DataBindings.Add("Text", patientBindingSource, "IssueDescription", false, DataSourceUpdateMode.Never);
            appointmentIdLabel.DataBindings.Add("Text", patientBindingSource, "Id", false, DataSourceUpdateMode.Never);
            doctorIDLabel.DataBindings.Add("Text", patientBindingSource, "DoctorId", false, DataSourceUpdateMode.Never);
            patientIDLabel.DataBindings.Add("Text", patientBindingSource, "PatientId", false, DataSourceUpdateMode.Never);
            appointmentTypeLabel.DataBindings.Add("Text", patientBindingSource, "AppointmentType", false, DataSourceUpdateMode.Never);
            billLabel.DataBindings.Add("Text", patientBindingSource, "TotalBill", false, DataSourceUpdateMode.Never);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptEmergencyButton_Click(object sender, EventArgs e)
        {

            if(appointmentTypeLabel.Text == "REG")
            {
                MessageBox.Show("This is a regular appointment.","Accept Appointment");
            }
            else
            {
                if(appointmentTimeLabel.Text.Length > 5)
                {
                    MessageBox.Show("Emergency appointment is already accepted", "Cannot accept");
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Click Yes to accept the emergency appointment", "Accept Appointment", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        String appId = appointmentIdLabel.Text;
                        int i = intermediary.acceptEmergencyAppointment(appId);
                        if (i > 0)
                        {
                            MessageBox.Show("Emergency Request Accepted", "Request Accepted");
                        }
                    }

                    appointmentTimeLabel.Text = "11:00 AM - 12:00 PM";
                

                }

            }
        }

        private void billAmounttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBillButton_Click(object sender, EventArgs e)
        {
            billEnteredErrorProvider.Clear();
            string enteredBill = billAmounttextBox.Text;
            if(enteredBill.Length < 1)
            {
                billEnteredErrorProvider.SetError(billAmounttextBox, "Please enter valid amount in bill");
            }
            else
            {
                int currentBill = Int32.Parse(billLabel.Text);
                int totalBill = currentBill + Int32.Parse(billAmounttextBox.Text);

               int res=  intermediary.AddBill(totalBill, appointmentIdLabel.Text);
                billLabel.Text = totalBill.ToString();
                if (res > 0)
                {
                    MessageBox.Show("Bill is successfully added", "Success");
                }
            else
            {
                    MessageBox.Show("Bill adding failed", "Failure");
            }
            }
        }
    }
}
