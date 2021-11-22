
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
            this.panelManagePatientBottom = new System.Windows.Forms.Panel();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalPatient = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.panelManagePatientMain.SuspendLayout();
            this.panelManagePatientBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManagePatientMain
            // 
            this.panelManagePatientMain.Controls.Add(this.panel1);
            this.panelManagePatientMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagePatientMain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelManagePatientMain.Location = new System.Drawing.Point(0, 0);
            this.panelManagePatientMain.Name = "panelManagePatientMain";
            this.panelManagePatientMain.Size = new System.Drawing.Size(800, 450);
            this.panelManagePatientMain.TabIndex = 0;
            // 
            // panelManagePatientBottom
            // 
            this.panelManagePatientBottom.BackColor = System.Drawing.Color.Teal;
            this.panelManagePatientBottom.Controls.Add(this.btnViewPatient);
            this.panelManagePatientBottom.Controls.Add(this.btnAddPatient);
            this.panelManagePatientBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManagePatientBottom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelManagePatientBottom.Location = new System.Drawing.Point(0, 400);
            this.panelManagePatientBottom.Name = "panelManagePatientBottom";
            this.panelManagePatientBottom.Size = new System.Drawing.Size(800, 50);
            this.panelManagePatientBottom.TabIndex = 1;
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewPatient.Location = new System.Drawing.Point(212, 5);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(148, 33);
            this.btnViewPatient.TabIndex = 1;
            this.btnViewPatient.Text = "ViewPatient";
            this.btnViewPatient.UseVisualStyleBackColor = false;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddPatient.Location = new System.Drawing.Point(67, 5);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(120, 33);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.labelTotalPatient);
            this.panel1.Controls.Add(this.labelT);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(300, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 150);
            this.panel1.TabIndex = 4;
            // 
            // labelTotalPatient
            // 
            this.labelTotalPatient.AutoSize = true;
            this.labelTotalPatient.Location = new System.Drawing.Point(89, 73);
            this.labelTotalPatient.Name = "labelTotalPatient";
            this.labelTotalPatient.Size = new System.Drawing.Size(31, 36);
            this.labelTotalPatient.TabIndex = 1;
            this.labelTotalPatient.Text = "0";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelT.Location = new System.Drawing.Point(39, 24);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(141, 28);
            this.labelT.TabIndex = 0;
            this.labelT.Text = "Total Patient";
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
            this.panelManagePatientBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManagePatientMain;
        private System.Windows.Forms.Panel panelManagePatientBottom;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalPatient;
        private System.Windows.Forms.Label labelT;
    }
}