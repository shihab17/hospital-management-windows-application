
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
            this.btnDoctorView = new System.Windows.Forms.Button();
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
            this.panelLeft.BackColor = System.Drawing.Color.Teal;
            this.panelLeft.Controls.Add(this.btnDoctorView);
            this.panelLeft.Controls.Add(this.panelAppoinment);
            this.panelLeft.Controls.Add(this.btnAppointment);
            this.panelLeft.Controls.Add(this.btnDashboard);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 511);
            this.panelLeft.TabIndex = 0;
            // 
            // btnDoctorView
            // 
            this.btnDoctorView.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDoctorView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorView.ForeColor = System.Drawing.Color.White;
            this.btnDoctorView.Location = new System.Drawing.Point(0, 177);
            this.btnDoctorView.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctorView.Name = "btnDoctorView";
            this.btnDoctorView.Size = new System.Drawing.Size(200, 44);
            this.btnDoctorView.TabIndex = 3;
            this.btnDoctorView.Text = "Doctor";
            this.btnDoctorView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorView.UseVisualStyleBackColor = false;
            this.btnDoctorView.Click += new System.EventHandler(this.btnDoctorView_Click);
            // 
            // panelAppoinment
            // 
            this.panelAppoinment.Controls.Add(this.btnViewAppoinment);
            this.panelAppoinment.Controls.Add(this.btnAddAppointment);
            this.panelAppoinment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppoinment.Location = new System.Drawing.Point(0, 92);
            this.panelAppoinment.Margin = new System.Windows.Forms.Padding(4);
            this.panelAppoinment.Name = "panelAppoinment";
            this.panelAppoinment.Size = new System.Drawing.Size(200, 85);
            this.panelAppoinment.TabIndex = 2;
            // 
            // btnViewAppoinment
            // 
            this.btnViewAppoinment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewAppoinment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAppoinment.ForeColor = System.Drawing.Color.White;
            this.btnViewAppoinment.Location = new System.Drawing.Point(0, 38);
            this.btnViewAppoinment.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAppoinment.Name = "btnViewAppoinment";
            this.btnViewAppoinment.Size = new System.Drawing.Size(200, 38);
            this.btnViewAppoinment.TabIndex = 1;
            this.btnViewAppoinment.Text = "View Appointment";
            this.btnViewAppoinment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewAppoinment.UseVisualStyleBackColor = false;
            this.btnViewAppoinment.Click += new System.EventHandler(this.btnViewAppoinment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(0, 0);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(200, 38);
            this.btnAddAppointment.TabIndex = 0;
            this.btnAddAppointment.Text = "New Appointment";
            this.btnAddAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.Location = new System.Drawing.Point(0, 48);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(200, 44);
            this.btnAppointment.TabIndex = 1;
            this.btnAppointment.Text = "Appoinment";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 48);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 50);
            this.panelTop.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(884, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(100, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 50);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(784, 511);
            this.panelMain.TabIndex = 2;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
        private System.Windows.Forms.Button btnDoctorView;
    }
}