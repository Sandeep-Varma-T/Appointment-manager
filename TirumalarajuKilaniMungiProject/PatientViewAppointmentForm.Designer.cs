namespace TirumalarajuKilaniMungiProject
{
    partial class PatientViewAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearContentsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.appointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.appointmentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.firstNameerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearContentsButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.appointmentIDTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(346, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Appointment";
            // 
            // clearContentsButton
            // 
            this.clearContentsButton.Location = new System.Drawing.Point(281, 397);
            this.clearContentsButton.Name = "clearContentsButton";
            this.clearContentsButton.Size = new System.Drawing.Size(121, 37);
            this.clearContentsButton.TabIndex = 5;
            this.clearContentsButton.Text = "Clear contents";
            this.clearContentsButton.UseVisualStyleBackColor = true;
            this.clearContentsButton.Click += new System.EventHandler(this.clearContentsButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(51, 397);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 37);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Location = new System.Drawing.Point(113, 288);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(205, 24);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appointmentIDTextBox.Location = new System.Drawing.Point(113, 148);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.Size = new System.Drawing.Size(205, 24);
            this.appointmentIDTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter First Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Appointment ID :";
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(518, 595);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(89, 37);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // appointmentErrorProvider
            // 
            this.appointmentErrorProvider.ContainerControl = this;
            // 
            // firstNameerrorProvider
            // 
            this.firstNameerrorProvider.ContainerControl = this;
            // 
            // PatientViewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientViewAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientViewAppointmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox appointmentIDTextBox;
        private System.Windows.Forms.Button clearContentsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ErrorProvider appointmentErrorProvider;
        private System.Windows.Forms.ErrorProvider firstNameerrorProvider;
    }
}