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
    public partial class DoctorViewApppointmentsForm : Form
    {
        private static DoctorViewApppointmentsForm doctorViewApppointmentsFormInst = null;
        private DrConsult mdiInst;
        private DrConsultIntermediary intermediary = new DrConsultIntermediary();
        private DoctorViewApppointmentsForm(DrConsult mdiInst)
        {
            InitializeComponent();
            this.mdiInst = mdiInst;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if(doctorUniqueIDTextBox.Text == "")
            {
                uniqueIdErrorProvider.SetError(doctorUniqueIDTextBox, "Please enter valid Id");
            }
            else if(firstnameTextBox.Text == "")
            {
                firstNameErrorProvider.SetError(firstnameTextBox, "Please enter value for first name");
            }
            else
            {
                int validate = intermediary.validateDoctor(doctorUniqueIDTextBox.Text, firstnameTextBox.Text);

                if(validate > 0)
                {
                    DataSet ds = intermediary.getAllPatients(doctorUniqueIDTextBox.Text);
                    if (ds.Tables[0].Rows.Count < 1)
                    {
                        MessageBox.Show("Currenlty there are no patients assigned to you", "No Patients Found");
                    }
                    else
                    {
                        DoctorScheduledAppointmentsForm doctorScheduledAppointmentsForm = new DoctorScheduledAppointmentsForm(mdiInst,ds);
                        doctorScheduledAppointmentsForm.MdiParent = mdiInst;
                        doctorScheduledAppointmentsForm.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid details");
                    firstnameTextBox.Text = "";
                }
            }
        }

        public static DoctorViewApppointmentsForm DoctorViewApppointmentsSingletonForm(DrConsult mdiInst)
        {
            if (doctorViewApppointmentsFormInst == null)
            {
                doctorViewApppointmentsFormInst = new DoctorViewApppointmentsForm(mdiInst);
                return doctorViewApppointmentsFormInst;
            }

            return doctorViewApppointmentsFormInst;
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            doctorViewApppointmentsFormInst = null;
        }

        private void clearContentsButton_Click(object sender, EventArgs e)
        {
            doctorUniqueIDTextBox.Text = "";
            firstnameTextBox.Text = "";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
