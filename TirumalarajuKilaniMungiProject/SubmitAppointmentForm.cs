using System;
using System.Data;
using System.Windows.Forms;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    public partial class SubmitAppointmentForm : Form
    {
        private DrConsult mdiInst;
        private SearchForAppointmentForm searchForAppointmentFormInst;
        private Appointment appointmentDetails;
        private bool error;
        private Patients patient;
        public String appointmentId;
        public SubmitAppointmentForm(DrConsult mdiInst, SearchForAppointmentForm searchForAppointmentFormInst, Appointment appointmentDetails)
        {
            InitializeComponent();
            this.mdiInst = mdiInst;
            this.searchForAppointmentFormInst = searchForAppointmentFormInst;
            this.appointmentDetails = appointmentDetails;
            if(appointmentDetails.GetAppointmentType() == "REG")
            {
                emergencyDescriptionLabel.Visible = false;
                emergencyTextBox.Visible = false;
            }
            else
            {
                emergencyDescriptionLabel.Visible = true;
                emergencyTextBox.Visible = true;
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you Cancel the appointment, all the fields will be cleared and the appointment will not be scheduled. Click YES to cancel the appointment", "Appointment Cancellation", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
                searchForAppointmentFormInst.Visible = true;
            }

        }

        private void submitRequestButton_Click(object sender, EventArgs e)
        {
            error = false;
            firstNameErrorProvider.Clear();
            emailErrorProvider.Clear();
            addressErrorProvider.Clear();
            briefDescriptionErrorProvider.Clear();
            phoneNumberErrorProvider.Clear();

            if (appointmentDetails.GetAppointmentType() == "EME")
            {
                emergencyErrorProvider.Clear();
            }
            if (firstNameTextBox.Text.Length < 1)
            {
                firstNameErrorProvider.SetError(firstNameTextBox,"First Name Should be atleast 1 character long");
                error = true;
            }
            if(lastNameTextBox.Text.Length < 1)
            {
                lastNameTextBox.Text = " ";
            }
            if(emailTextBox.Text.Length < 1)
            {
                emailErrorProvider.SetError(emailTextBox, "Please enter a valid email");
                error  =true;
            }
            if(phoneNumberTextBox.Text.Length < 1)
            {
                phoneNumberErrorProvider.SetError(phoneNumberTextBox, "Please enter your phone number to proceed");
                error = true;
            }
            if (addressTextBox.Text.Length < 1)
            {
                addressErrorProvider.SetError(addressTextBox, "Please enter your address");
                error = true;
            }
            if (briefDescriptionTextBox.Text.Length < 25)
            {
                briefDescriptionErrorProvider.SetError(briefDescriptionTextBox, "Please enter a description that should be atleast 25 characters long");
                error = true;
            }
            if(appointmentDetails.GetAppointmentType() == "EME" && emergencyTextBox.Text.Length < 25)
            {
                emergencyErrorProvider.SetError(emergencyTextBox, "Please enter emergency description that is atleast 25 characters long");
                error = true;
            }

            
            if (!error)
            {
                DialogResult dialogResult;
                if (appointmentDetails.GetAppointmentType() == "REG")
                {
                    dialogResult = MessageBox.Show("Click Yes to confirm the appointment", "Appointment Confirmation", MessageBoxButtons.YesNo);
                }
                else
                {
                    dialogResult = MessageBox.Show("You are making an emergency appointment. Time slot for the appointment will be decided by the doctor. Please note that doctor has the right to reject the emergency appointment. Click Yes to proceed with the appointment", "Appointment Confirmation", MessageBoxButtons.YesNo);
                }
                if (dialogResult == DialogResult.Yes)
                {
                    DrConsultIntermediary drConsultIntermediary = new DrConsultIntermediary();
                    //write query to create a new patient and update the appointments
                    GeneratePatient();
                    GenerateAppointment();
                    int isRegistered = drConsultIntermediary.RegisterPatient(patient);
                    int isScheduled = drConsultIntermediary.MakeAppointment(appointmentDetails,patient);
                    int isSlotUpdated = 0;

                    if (appointmentDetails.GetAppointmentType() == "REG")
                    {
                        isSlotUpdated = drConsultIntermediary.UpdateSlots(Int32.Parse(appointmentDetails.slotId));
                    }
                    else
                    {
                        isSlotUpdated = 1;
                    }

                if(isRegistered>0 && isScheduled > 0 && isSlotUpdated > 0)
                    {
                        MessageBox.Show($"Appointment Successful. Please use the below appointment Id for further reference : \n\n {appointmentDetails.appointmentId}", "Success");
                        this.Close();
                        searchForAppointmentFormInst.Close();
                    }
                }
            }
        }


        private void GeneratePatient()
        {
            this.patient = new Patients();
            patient.firstName = firstNameTextBox.Text;
            patient.lastName = lastNameTextBox.Text;
            patient.phoneNumber = phoneNumberTextBox.Text;
            patient.email = emailTextBox.Text;
            patient.address = addressTextBox.Text;
            patient.userType = "PAT";
            patient.id = patient.GenerateRandomIdForPatient();       

        }

        private void GenerateAppointment()
        {
            appointmentDetails.appointmentDescription = briefDescriptionTextBox.Text;
            appointmentDetails.emergencyDescription = emergencyTextBox.Text;
            appointmentDetails.patientId = patient.id;
            appointmentId = appointmentDetails.GenerateRandomIdForAppointment();
            appointmentDetails.appointmentId = appointmentId;
        }

        private void ClearFieldsButton(object sender, EventArgs e)
        {
            //Clear all the text fields and error providers
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";
            briefDescriptionTextBox.Text = "";
            firstNameErrorProvider.Clear();
            emailErrorProvider.Clear();
            addressErrorProvider.Clear();
            briefDescriptionErrorProvider.Clear();
            phoneNumberErrorProvider.Clear();
            if (appointmentDetails.GetAppointmentType() == "EME")
            {
                emergencyTextBox.Text = "";
                emergencyErrorProvider.Clear();
            }
        }
    }
}
