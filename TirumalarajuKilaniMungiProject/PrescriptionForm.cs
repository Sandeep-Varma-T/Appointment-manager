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
    public partial class PrescriptionForm : Form
    {
        private DataSet ds;
        private PatientScheduledAppointmentForm inst;
        public PrescriptionForm(DataSet ds, PatientScheduledAppointmentForm inst)
        {
            InitializeComponent();
            this.ds = ds;
            BindingSource prescriptionBindingSource = new BindingSource();
            prescriptionBindingSource.DataSource = ds.Tables[0];
            dataGridView1.DataSource = prescriptionBindingSource;
            drugNameLabel.DataBindings.Add("Text", prescriptionBindingSource, "DrugName", false, DataSourceUpdateMode.Never);
            drugInstructionsLabel.DataBindings.Add("Text", prescriptionBindingSource, "DrugInstructions", false, DataSourceUpdateMode.Never);
            this.inst = inst;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
