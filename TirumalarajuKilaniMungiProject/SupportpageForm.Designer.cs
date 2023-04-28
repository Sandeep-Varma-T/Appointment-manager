namespace TirumalarajuKilaniMungiProject
{
    partial class SupportpageForm
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
            this.supportLabel = new System.Windows.Forms.Label();
            this.emailSupportButton = new System.Windows.Forms.Button();
            this.phoneSupport = new System.Windows.Forms.Button();
            this.chatSupport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supportLabel
            // 
            this.supportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportLabel.Location = new System.Drawing.Point(34, 209);
            this.supportLabel.Name = "supportLabel";
            this.supportLabel.Size = new System.Drawing.Size(665, 145);
            this.supportLabel.TabIndex = 1;
            this.supportLabel.Text = "label2";
            // 
            // emailSupportButton
            // 
            this.emailSupportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSupportButton.Location = new System.Drawing.Point(37, 61);
            this.emailSupportButton.Name = "emailSupportButton";
            this.emailSupportButton.Size = new System.Drawing.Size(119, 64);
            this.emailSupportButton.TabIndex = 2;
            this.emailSupportButton.Text = "Email Support";
            this.emailSupportButton.UseVisualStyleBackColor = true;
            this.emailSupportButton.Click += new System.EventHandler(this.emailSupportButton_Click);
            // 
            // phoneSupport
            // 
            this.phoneSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSupport.Location = new System.Drawing.Point(305, 61);
            this.phoneSupport.Name = "phoneSupport";
            this.phoneSupport.Size = new System.Drawing.Size(119, 64);
            this.phoneSupport.TabIndex = 3;
            this.phoneSupport.Text = "Phone Support";
            this.phoneSupport.UseVisualStyleBackColor = true;
            this.phoneSupport.Click += new System.EventHandler(this.phoneSupport_Click);
            // 
            // chatSupport
            // 
            this.chatSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatSupport.Location = new System.Drawing.Point(580, 61);
            this.chatSupport.Name = "chatSupport";
            this.chatSupport.Size = new System.Drawing.Size(119, 64);
            this.chatSupport.TabIndex = 4;
            this.chatSupport.Text = "Chat Support";
            this.chatSupport.UseVisualStyleBackColor = true;
            this.chatSupport.Click += new System.EventHandler(this.chatSupport_Click);
            // 
            // SupportpageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chatSupport);
            this.Controls.Add(this.phoneSupport);
            this.Controls.Add(this.emailSupportButton);
            this.Controls.Add(this.supportLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupportpageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupportpageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label supportLabel;
        private System.Windows.Forms.Button emailSupportButton;
        private System.Windows.Forms.Button phoneSupport;
        private System.Windows.Forms.Button chatSupport;
    }
}