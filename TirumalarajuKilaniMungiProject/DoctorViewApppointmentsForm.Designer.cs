namespace TirumalarajuKilaniMungiProject
{
    partial class DoctorViewApppointmentsForm
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
            this.homeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearContentsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.doctorUniqueIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uniqueIdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.firstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueIdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(530, 561);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(89, 37);
            this.homeButton.TabIndex = 8;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearContentsButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.firstnameTextBox);
            this.groupBox1.Controls.Add(this.doctorUniqueIDTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(358, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 466);
            this.groupBox1.TabIndex = 7;
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
            this.searchButton.Location = new System.Drawing.Point(27, 397);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(169, 37);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search Appointments";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstnameTextBox.Location = new System.Drawing.Point(113, 288);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(205, 24);
            this.firstnameTextBox.TabIndex = 3;
            // 
            // doctorUniqueIDTextBox
            // 
            this.doctorUniqueIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorUniqueIDTextBox.Location = new System.Drawing.Point(113, 148);
            this.doctorUniqueIDTextBox.Name = "doctorUniqueIDTextBox";
            this.doctorUniqueIDTextBox.Size = new System.Drawing.Size(205, 24);
            this.doctorUniqueIDTextBox.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(110, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Unique Doctor ID : ";
            // 
            // uniqueIdErrorProvider
            // 
            this.uniqueIdErrorProvider.ContainerControl = this;
            // 
            // firstNameErrorProvider
            // 
            this.firstNameErrorProvider.ContainerControl = this;
            // 
            // DoctorViewApppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorViewApppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctorViewApppointmentsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueIdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearContentsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox doctorUniqueIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider uniqueIdErrorProvider;
        private System.Windows.Forms.ErrorProvider firstNameErrorProvider;
    }
}