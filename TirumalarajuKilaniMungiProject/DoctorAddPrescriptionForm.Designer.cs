namespace TirumalarajuKilaniMungiProject
{
    partial class DoctorAddPrescriptionForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.drugNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearContentsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.drugNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.instructionsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drugNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionsErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prescripton Added Till Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add New Prescription Below :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drug Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Instructions (no more than 50 words):";
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsTextBox.Location = new System.Drawing.Point(310, 279);
            this.instructionsTextBox.Multiline = true;
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.instructionsTextBox.Size = new System.Drawing.Size(479, 65);
            this.instructionsTextBox.TabIndex = 5;
            // 
            // drugNameTextBox
            // 
            this.drugNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drugNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugNameTextBox.Location = new System.Drawing.Point(444, 176);
            this.drugNameTextBox.Name = "drugNameTextBox";
            this.drugNameTextBox.Size = new System.Drawing.Size(360, 27);
            this.drugNameTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(310, 488);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 34);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearContentsButton
            // 
            this.clearContentsButton.Location = new System.Drawing.Point(475, 488);
            this.clearContentsButton.Name = "clearContentsButton";
            this.clearContentsButton.Size = new System.Drawing.Size(118, 34);
            this.clearContentsButton.TabIndex = 8;
            this.clearContentsButton.Text = "Clear Contents";
            this.clearContentsButton.UseVisualStyleBackColor = true;
            this.clearContentsButton.Click += new System.EventHandler(this.clearContentsButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(640, 488);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 34);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // drugNameErrorProvider
            // 
            this.drugNameErrorProvider.ContainerControl = this;
            // 
            // instructionsErrorProvider
            // 
            this.instructionsErrorProvider.ContainerControl = this;
            // 
            // DoctorAddPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearContentsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.drugNameTextBox);
            this.Controls.Add(this.instructionsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorAddPrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorAddPrescriptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.drugNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionsErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.TextBox drugNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearContentsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ErrorProvider drugNameErrorProvider;
        private System.Windows.Forms.ErrorProvider instructionsErrorProvider;
    }
}