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
    public partial class DoctorAddPrescriptionForm : Form
    {
        DoctorScheduledAppointmentsForm inst;
        string doctorId;
        string patientId;
        DrConsultIntermediary intermediary = new DrConsultIntermediary();
        
        public DoctorAddPrescriptionForm(DoctorScheduledAppointmentsForm inst,string doctorId,string patientId)
        {
            InitializeComponent();
            this.inst = inst;
            this.patientId = patientId;
            this.doctorId = doctorId;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            inst.Visible = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            drugNameErrorProvider.Clear();
            instructionsErrorProvider.Clear();
            if(drugNameTextBox.Text.Length < 1)
            {
                drugNameErrorProvider.SetError(drugNameTextBox,"Please enter a drug name");
            }
            else if(instructionsTextBox.Text.Length < 10)
            {
                instructionsErrorProvider.SetError(instructionsTextBox, "Please enter instructions atleast 110 characters long");
            }
            else
            {
               int isSuccess= intermediary.addPrescription(doctorId, patientId, drugNameTextBox.Text, instructionsTextBox.Text);

                if(isSuccess > 0)
                {
                    MessageBox.Show("Successfullly added prescription", "Success");
                    inst.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to add prescription", "Failed");
                }
            }
        }

        private void clearContentsButton_Click(object sender, EventArgs e)
        {
            drugNameTextBox.Text = "";
            instructionsTextBox.Text = "";
        }
    }
}
