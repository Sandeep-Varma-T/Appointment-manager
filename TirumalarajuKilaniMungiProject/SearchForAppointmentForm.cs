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
    //This is a form to enter pincode and specilization and search for the doctors
    public partial class SearchForAppointmentForm : Form
    {
        private static SearchForAppointmentForm searchForAppointmentFormInst = null;
        private DrConsult mdiInst;
        private DrConsultIntermediary intermediary;
        private SearchForAppointmentForm(DrConsult mdiInst)
        {
            InitializeComponent();
            this.mdiInst = mdiInst;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            //Checking if the pincode is not null

            pinCodeErrorProvider.Clear();
            specilizationErrorProvider.Clear();
            if(pinCodeTextBox.Text.Length == 0){
                pinCodeErrorProvider.SetError(pinCodeTextBox, "Please enter a value for the pin code");
            }
            else
            {
                //Checking if the pincode is all digits using lambdas
                bool isAllDigits = !pinCodeTextBox.Text.Any(ch => ch < '0' || ch > '9');
                if (!isAllDigits)
                    {
                        pinCodeErrorProvider.SetError(pinCodeTextBox, "Please enter a valid pin code");
                    }
                //Checking if the specilization is selected or not
                else if (specilizationComboBox.SelectedIndex == -1)
                {
                    specilizationErrorProvider.SetError(specilizationComboBox, "Please select a value for the Specilization");
                }
                //Initializaing schedule appointment form once all the validations are passed.
                else
                {
                    //get all the doctors based on the specilization and pincode

                    intermediary = new DrConsultIntermediary();
                    DataSet ds = intermediary.getDoctorsBasedOnCriteria(specilizationComboBox.Text, pinCodeTextBox.Text);

                    //if no doctors are found show alert and clear all the fields
                    if(ds.Tables[0].Rows.Count < 1)
                    {
                        string message = "No doctors found in the area. Please search again using different pincode.";
                        string title = "Doctors not found";
                        MessageBox.Show(message, title);
                        pinCodeTextBox.Text = "";
                        specilizationComboBox.SelectedIndex = -1;

                    }

                    //if doctors are found initiate the next form to schedule the appointments with the doctors
                    else
                    {
                        ScheduleAppointmentForm scheduleAppointment = new           ScheduleAppointmentForm(mdiInst, this, ds.Tables[0]);
                        scheduleAppointment.MdiParent = mdiInst;
                        this.Visible = false;
                        scheduleAppointment.Show();
                    }
                    
                }
            }
        }

        public static SearchForAppointmentForm SingletonSearchForAppointmentForm(DrConsult mdiInst)
        {
            if(searchForAppointmentFormInst == null)
            {
                searchForAppointmentFormInst = new SearchForAppointmentForm(mdiInst);
                return searchForAppointmentFormInst;
            }

            return searchForAppointmentFormInst;
        }//Singleton method

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            searchForAppointmentFormInst = null;
        }//Form Close

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//home button click
    }//class
}//namespace
