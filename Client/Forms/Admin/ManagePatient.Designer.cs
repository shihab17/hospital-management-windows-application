
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class ManagePatient
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
            this.panelManagePatientMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelManagePatientBottom = new System.Windows.Forms.Panel();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.panelManagePatientMain.SuspendLayout();
            this.panelManagePatientBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManagePatientMain
            // 
            this.panelManagePatientMain.Controls.Add(this.label1);
            this.panelManagePatientMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagePatientMain.Location = new System.Drawing.Point(0, 0);
            this.panelManagePatientMain.Name = "panelManagePatientMain";
            this.panelManagePatientMain.Size = new System.Drawing.Size(800, 450);
            this.panelManagePatientMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to PAtient";
            // 
            // panelManagePatientBottom
            // 
            this.panelManagePatientBottom.Controls.Add(this.btnViewPatient);
            this.panelManagePatientBottom.Controls.Add(this.btnAddPatient);
            this.panelManagePatientBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManagePatientBottom.Location = new System.Drawing.Point(0, 350);
            this.panelManagePatientBottom.Name = "panelManagePatientBottom";
            this.panelManagePatientBottom.Size = new System.Drawing.Size(800, 100);
            this.panelManagePatientBottom.TabIndex = 1;
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Location = new System.Drawing.Point(203, 36);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(100, 33);
            this.btnViewPatient.TabIndex = 1;
            this.btnViewPatient.Text = "ViewPatient";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(61, 36);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(100, 33);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelManagePatientBottom);
            this.Controls.Add(this.panelManagePatientMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePatient";
            this.Text = "ManagePatient";
            this.panelManagePatientMain.ResumeLayout(false);
            this.panelManagePatientMain.PerformLayout();
            this.panelManagePatientBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManagePatientMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelManagePatientBottom;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.Button btnAddPatient;
    }
}