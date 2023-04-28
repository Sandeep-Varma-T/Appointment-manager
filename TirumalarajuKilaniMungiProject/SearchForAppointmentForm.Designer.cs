namespace TirumalarajuKilaniMungiProject
{
    partial class SearchForAppointmentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pinCodeTextBox = new System.Windows.Forms.TextBox();
            this.specilizationComboBox = new System.Windows.Forms.ComboBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.pinCodeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.specilizationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pinCodeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specilizationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please use the below search criteria to search for the Doctors :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pin Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specilization :";
            // 
            // pinCodeTextBox
            // 
            this.pinCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinCodeTextBox.Location = new System.Drawing.Point(164, 177);
            this.pinCodeTextBox.Name = "pinCodeTextBox";
            this.pinCodeTextBox.Size = new System.Drawing.Size(173, 30);
            this.pinCodeTextBox.TabIndex = 3;
            // 
            // specilizationComboBox
            // 
            this.specilizationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specilizationComboBox.FormattingEnabled = true;
            this.specilizationComboBox.Items.AddRange(new object[] {
            "Dermatologist",
            "Orthopedic Surgeon",
            "Neurologist",
            "Urologist",
            "Dentist",
            "General Physician"});
            this.specilizationComboBox.Location = new System.Drawing.Point(191, 250);
            this.specilizationComboBox.Name = "specilizationComboBox";
            this.specilizationComboBox.Size = new System.Drawing.Size(255, 33);
            this.specilizationComboBox.TabIndex = 4;
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(33, 461);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(152, 47);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "&Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(273, 461);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(152, 47);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pinCodeErrorProvider
            // 
            this.pinCodeErrorProvider.ContainerControl = this;
            // 
            // specilizationErrorProvider
            // 
            this.specilizationErrorProvider.ContainerControl = this;
            // 
            // SearchForAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.specilizationComboBox);
            this.Controls.Add(this.pinCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleAppointmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.pinCodeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specilizationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pinCodeTextBox;
        private System.Windows.Forms.ComboBox specilizationComboBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ErrorProvider pinCodeErrorProvider;
        private System.Windows.Forms.ErrorProvider specilizationErrorProvider;
    }
}