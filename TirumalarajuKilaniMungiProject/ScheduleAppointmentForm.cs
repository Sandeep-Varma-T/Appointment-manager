using System;
using System.Data;
using System.Windows.Forms;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    public partial class ScheduleAppointmentForm : Form
    {
        private DrConsult mdiInst;
        private SearchForAppointmentForm searchForAppointmentFormInst;
        private string doctorId;
        private string appointmentDate;
        private DrConsultIntermediary intermediary;
        public ScheduleAppointmentForm(DrConsult mdiInst, SearchForAppointmentForm searchForAppointmentFormInst, DataTable doctorsFound)
        {
            doctorId = doctorsFound.Rows[0][0].ToString();
            InitializeComponent();
            this.mdiInst = mdiInst;
            this.searchForAppointmentFormInst = searchForAppointmentFormInst;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = doctorsFound;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Specilization"].Visible = false;
            //setting the Date picker to allow users to choosed from the next 5 days
            appointmentDateTimePicker.MinDate = DateTime.Today.AddDays(1);
            appointmentDateTimePicker.MaxDate = DateTime.Today.AddDays(5);
            this.appointmentDate = appointmentDateTimePicker.Value.ToString("MM/dd/yyyy");
            regularAppointmentButton.Enabled = false;
        }

        //Method to book a Emergency appointment
        private void requestEmergencyButton_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("You are booking an emergency request. For the emergency appointment to be booked, it needs to be accepted by the doctor. Click YES to proceed or NO to go back and book a regular appointment if available for another date", "Emergency Request",MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {

                Appointment newAppointment = new Appointment(doctorId, appointmentDate, appointmentDateTimePicker.Value.DayOfWeek.ToString(), appointmentTimeComboBox.Text, "EME");
                SubmitAppointmentForm submitAppointment = new SubmitAppointmentForm(mdiInst, searchForAppointmentFormInst, newAppointment);
                this.Visible = false;
                submitAppointment.MdiParent = mdiInst;
                submitAppointment.Show();
            }

        }

        //Method to book a regular appointment
        private void regularAppointmentButton_Click(object sender, EventArgs e)
        {

            if (appointmentTimeComboBox.SelectedIndex < 0)
            {
                appointmentTimeErrorProvider.SetError(appointmentTimeComboBox, "Please select a slot before booking the appointment");
            }
            else
            {

                string msg = $"Click YES to proceed with the regular appointment with the below details\n Doctor Name : {doctorNameLabel.Text} \n Clinic Address : {doctorAddressLabel.Text}\n Specilization : {specilizationLabel.Text} \n Appointment Date : {appointmentDateTimePicker.Text}\n Appointment Time : {appointmentTimeComboBox.Text}\n Click NO to cancel the booking";

                DialogResult dialogResult = MessageBox.Show(msg, "Regular Appointment", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Appointment newAppointment = new Appointment(doctorId, appointmentDate, appointmentDateTimePicker.Value.DayOfWeek.ToString(), appointmentTimeComboBox.Text, "REG");
                    int appointmentSlot =
                     DrConsult.slotTimes.FindIndex(a => a.Contains(appointmentTimeComboBox.Text));

                    DataSet ds = intermediary.GetSlotId(doctorId, appointmentDate, appointmentSlot);
                    string slotId = ds.Tables[0].Rows[0][0].ToString();

                    newAppointment.slotId = slotId;
                    SubmitAppointmentForm submitAppointment = new SubmitAppointmentForm(mdiInst, searchForAppointmentFormInst, newAppointment);
                    submitAppointment.MdiParent = mdiInst;
                    submitAppointment.Show();
                    this.Visible = false;

                }

            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            searchForAppointmentFormInst.Visible = true;
        }

        //This method populates the fields in the form as per the doctor selected by the user
        private void DoctorsSelectionChanged(object sender, EventArgs e)
        { 
            doctorId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            doctorNameLabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            hospitalNameLabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            doctorAddressLabel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            specilizationLabel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            doctorId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            appointmentDateTimePicker.Value = DateTime.Today.AddDays(1);
            appointmentTimeComboBox.Text = "";
            appointmentTimeErrorProvider.Clear();
            appointmentTimeComboBox.Enabled = false;


        }

        //This method is fired when ever the appointment date has been changed by the user and adjusts the appointment times accordingly.
        private void AppointmentDateValueChange(object sender, EventArgs e)
        {

            appointmentTimeComboBox.Enabled = false;
            appointmentTimeErrorProvider.Clear();
            appointmentTimeComboBox.Items.Clear();
            appointmentTimeComboBox.Text = "";
            regularAppointmentButton.Enabled = false;
         
        }

        //Method to display slots
        private void viewSlotsButton_Click(object sender, EventArgs e)
        {

            appointmentTimeComboBox.Items.Clear();
            this.appointmentDate = appointmentDateTimePicker.Value.ToString("MM/dd/yyyy");

            //Connecting to Intermediary class to retrieve Doctor slots based on the selected Doctor Id and date
            intermediary = new DrConsultIntermediary();
            DataTable dt = intermediary.getDoctorSlots(doctorId, appointmentDate).Tables[0];

            //Iterating through the slots and determining the available slots to populate the slot picker

            if (dt.Rows.Count == 0)
            {
                appointmentTimeErrorProvider.SetError(appointmentTimeComboBox, "There are no available slots for the selected date");
                appointmentTimeComboBox.Enabled = false;
            }
            else
            {
                appointmentTimeComboBox.Enabled = true;
                regularAppointmentButton.Enabled = true;
            }
            foreach (DataRow row in dt.Rows)
            {

                appointmentTimeComboBox.Items.Add(DrConsult.slotTimes[int.Parse(row[4].ToString())]);
            }

        }
    }
}
