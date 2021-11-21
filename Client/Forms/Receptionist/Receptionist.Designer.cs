
namespace Hospital_Management_System.Client.Forms.Receptionist
{
    partial class Receptionist
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelAppoinment = new System.Windows.Forms.Panel();
            this.btnViewAppoinment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelAppoinment.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelAppoinment);
            this.panelLeft.Controls.Add(this.btnAppointment);
            this.panelLeft.Controls.Add(this.btnDashboard);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 49);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 402);
            this.panelLeft.TabIndex = 0;
            // 
            // panelAppoinment
            // 
            this.panelAppoinment.Controls.Add(this.btnViewAppoinment);
            this.panelAppoinment.Controls.Add(this.btnAddAppointment);
            this.panelAppoinment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppoinment.Location = new System.Drawing.Point(0, 76);
            this.panelAppoinment.Name = "panelAppoinment";
            this.panelAppoinment.Size = new System.Drawing.Size(200, 61);
            this.panelAppoinment.TabIndex = 2;
            // 
            // btnViewAppoinment
            // 
            this.btnViewAppoinment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAppoinment.Location = new System.Drawing.Point(0, 27);
            this.btnViewAppoinment.Name = "btnViewAppoinment";
            this.btnViewAppoinment.Size = new System.Drawing.Size(200, 27);
            this.btnViewAppoinment.TabIndex = 1;
            this.btnViewAppoinment.Text = "View Appointment";
            this.btnViewAppoinment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewAppoinment.UseVisualStyleBackColor = true;
            this.btnViewAppoinment.Click += new System.EventHandler(this.btnViewAppoinment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAppointment.Location = new System.Drawing.Point(0, 0);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(200, 27);
            this.btnAddAppointment.TabIndex = 0;
            this.btnAddAppointment.Text = "New Appointment";
            this.btnAddAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointment.Location = new System.Drawing.Point(0, 39);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(200, 37);
            this.btnAppointment.TabIndex = 1;
            this.btnAppointment.Text = "Appoinment";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 39);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(805, 49);
            this.panelTop.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(735, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(70, 49);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(605, 402);
            this.panelMain.TabIndex = 2;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.panelLeft.ResumeLayout(false);
            this.panelAppoinment.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelAppoinment;
        private System.Windows.Forms.Button btnViewAppoinment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMain;
    }
}