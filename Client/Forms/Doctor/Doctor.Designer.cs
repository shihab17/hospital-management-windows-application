
namespace Hospital_Management_System.Client.Forms.Doctor
{
    partial class Doctor
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
            this.panelDoctorTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelDoctorLeft = new System.Windows.Forms.Panel();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.btnDoctorProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelDoctorMain = new System.Windows.Forms.Panel();
            this.panelDoctorTop.SuspendLayout();
            this.panelDoctorLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDoctorTop
            // 
            this.panelDoctorTop.Controls.Add(this.btnLogout);
            this.panelDoctorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctorTop.Location = new System.Drawing.Point(0, 0);
            this.panelDoctorTop.Name = "panelDoctorTop";
            this.panelDoctorTop.Size = new System.Drawing.Size(800, 55);
            this.panelDoctorTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(730, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(70, 55);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelDoctorLeft
            // 
            this.panelDoctorLeft.Controls.Add(this.btnViewPatient);
            this.panelDoctorLeft.Controls.Add(this.btnDoctorProfile);
            this.panelDoctorLeft.Controls.Add(this.btnDashboard);
            this.panelDoctorLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDoctorLeft.Location = new System.Drawing.Point(0, 55);
            this.panelDoctorLeft.Name = "panelDoctorLeft";
            this.panelDoctorLeft.Size = new System.Drawing.Size(200, 395);
            this.panelDoctorLeft.TabIndex = 1;
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewPatient.Location = new System.Drawing.Point(0, 64);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(200, 32);
            this.btnViewPatient.TabIndex = 2;
            this.btnViewPatient.Text = "View Patient";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnDoctorProfile
            // 
            this.btnDoctorProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorProfile.Location = new System.Drawing.Point(0, 32);
            this.btnDoctorProfile.Name = "btnDoctorProfile";
            this.btnDoctorProfile.Size = new System.Drawing.Size(200, 32);
            this.btnDoctorProfile.TabIndex = 1;
            this.btnDoctorProfile.Text = "Profile";
            this.btnDoctorProfile.UseVisualStyleBackColor = true;
            this.btnDoctorProfile.Click += new System.EventHandler(this.btnDoctorProfile_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 32);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelDoctorMain
            // 
            this.panelDoctorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoctorMain.Location = new System.Drawing.Point(200, 55);
            this.panelDoctorMain.Name = "panelDoctorMain";
            this.panelDoctorMain.Size = new System.Drawing.Size(600, 395);
            this.panelDoctorMain.TabIndex = 2;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDoctorMain);
            this.Controls.Add(this.panelDoctorLeft);
            this.Controls.Add(this.panelDoctorTop);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.panelDoctorTop.ResumeLayout(false);
            this.panelDoctorLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDoctorTop;
        private System.Windows.Forms.Panel panelDoctorLeft;
        private System.Windows.Forms.Panel panelDoctorMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.Button btnDoctorProfile;
        private System.Windows.Forms.Button btnDashboard;
    }
}