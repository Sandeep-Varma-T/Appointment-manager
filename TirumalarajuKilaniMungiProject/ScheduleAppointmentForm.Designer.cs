namespace TirumalarajuKilaniMungiProject
{
    partial class ScheduleAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.doctorAddressLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.specilizationLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.requestEmergencyButton = new System.Windows.Forms.Button();
            this.regularAppointmentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTimeComboBox = new System.Windows.Forms.ComboBox();
            this.hospitalNameLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.appointmentTimeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.viewSlotsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTimeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the below available doctors to view their avialable slots for appointment " +
    ":";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 387);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DoctorsSelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hospital Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address :";
            // 
            // doctorAddressLabel
            // 
            this.doctorAddressLabel.AutoSize = true;
            this.doctorAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorAddressLabel.Location = new System.Drawing.Point(717, 202);
            this.doctorAddressLabel.Name = "doctorAddressLabel";
            this.doctorAddressLabel.Size = new System.Drawing.Size(0, 20);
            this.doctorAddressLabel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(558, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Specilization :";
            // 
            // specilizationLabel
            // 
            this.specilizationLabel.AutoSize = true;
            this.specilizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specilizationLabel.Location = new System.Drawing.Point(717, 249);
            this.specilizationLabel.Name = "specilizationLabel";
            this.specilizationLabel.Size = new System.Drawing.Size(0, 20);
            this.specilizationLabel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(558, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Appointment Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(558, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Appointment Time :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(529, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(485, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Select Emergency appointment or Regular Appointment :";
            // 
            // requestEmergencyButton
            // 
            this.requestEmergencyButton.Location = new System.Drawing.Point(550, 564);
            this.requestEmergencyButton.Name = "requestEmergencyButton";
            this.requestEmergencyButton.Size = new System.Drawing.Size(189, 39);
            this.requestEmergencyButton.TabIndex = 13;
            this.requestEmergencyButton.Text = "Emergency Appointment";
            this.requestEmergencyButton.UseVisualStyleBackColor = true;
            this.requestEmergencyButton.Click += new System.EventHandler(this.requestEmergencyButton_Click);
            // 
            // regularAppointmentButton
            // 
            this.regularAppointmentButton.Location = new System.Drawing.Point(788, 564);
            this.regularAppointmentButton.Name = "regularAppointmentButton";
            this.regularAppointmentButton.Size = new System.Drawing.Size(167, 39);
            this.regularAppointmentButton.TabIndex = 14;
            this.regularAppointmentButton.Text = "Regular Appointment";
            this.regularAppointmentButton.UseVisualStyleBackColor = true;
            this.regularAppointmentButton.Click += new System.EventHandler(this.regularAppointmentButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(29, 567);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 30);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(773, 305);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.appointmentDateTimePicker.TabIndex = 16;
            this.appointmentDateTimePicker.ValueChanged += new System.EventHandler(this.AppointmentDateValueChange);
            // 
            // appointmentTimeComboBox
            // 
            this.appointmentTimeComboBox.FormattingEnabled = true;
            this.appointmentTimeComboBox.Location = new System.Drawing.Point(773, 422);
            this.appointmentTimeComboBox.Name = "appointmentTimeComboBox";
            this.appointmentTimeComboBox.Size = new System.Drawing.Size(182, 24);
            this.appointmentTimeComboBox.TabIndex = 17;
            // 
            // hospitalNameLabel
            // 
            this.hospitalNameLabel.AutoSize = true;
            this.hospitalNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalNameLabel.Location = new System.Drawing.Point(717, 153);
            this.hospitalNameLabel.Name = "hospitalNameLabel";
            this.hospitalNameLabel.Size = new System.Drawing.Size(0, 20);
            this.hospitalNameLabel.TabIndex = 5;
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameLabel.Location = new System.Drawing.Point(717, 107);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(0, 20);
            this.doctorNameLabel.TabIndex = 3;
            // 
            // appointmentTimeErrorProvider
            // 
            this.appointmentTimeErrorProvider.ContainerControl = this;
            // 
            // viewSlotsButton
            // 
            this.viewSlotsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSlotsButton.Location = new System.Drawing.Point(658, 359);
            this.viewSlotsButton.Name = "viewSlotsButton";
            this.viewSlotsButton.Size = new System.Drawing.Size(177, 31);
            this.viewSlotsButton.TabIndex = 18;
            this.viewSlotsButton.Text = "Click to view slots";
            this.viewSlotsButton.UseVisualStyleBackColor = true;
            this.viewSlotsButton.Click += new System.EventHandler(this.viewSlotsButton_Click);
            // 
            // ScheduleAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 703);
            this.Controls.Add(this.viewSlotsButton);
            this.Controls.Add(this.appointmentTimeComboBox);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.regularAppointmentButton);
            this.Controls.Add(this.requestEmergencyButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.specilizationLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doctorAddressLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hospitalNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTimeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label doctorAddressLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label specilizationLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button requestEmergencyButton;
        private System.Windows.Forms.Button regularAppointmentButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.ComboBox appointmentTimeComboBox;
        private System.Windows.Forms.Label hospitalNameLabel;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.ErrorProvider appointmentTimeErrorProvider;
        private System.Windows.Forms.Button viewSlotsButton;
    }
}