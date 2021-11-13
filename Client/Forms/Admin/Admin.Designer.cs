
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class Admin
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
            this.panelAdminLeft = new System.Windows.Forms.Panel();
            this.panelEmpoyeSubMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.panelAdminHeader = new System.Windows.Forms.Panel();
            this.panelAdminMain = new System.Windows.Forms.Panel();
            this.panelAdminLeft.SuspendLayout();
            this.panelEmpoyeSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminLeft
            // 
            this.panelAdminLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAdminLeft.Controls.Add(this.panelEmpoyeSubMenu);
            this.panelAdminLeft.Controls.Add(this.btnEmploye);
            this.panelAdminLeft.Controls.Add(this.btnAdminDashboard);
            this.panelAdminLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminLeft.Location = new System.Drawing.Point(0, 47);
            this.panelAdminLeft.Name = "panelAdminLeft";
            this.panelAdminLeft.Size = new System.Drawing.Size(200, 489);
            this.panelAdminLeft.TabIndex = 0;
            // 
            // panelEmpoyeSubMenu
            // 
            this.panelEmpoyeSubMenu.Controls.Add(this.button2);
            this.panelEmpoyeSubMenu.Controls.Add(this.button1);
            this.panelEmpoyeSubMenu.Controls.Add(this.btnDoctor);
            this.panelEmpoyeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpoyeSubMenu.Location = new System.Drawing.Point(0, 60);
            this.panelEmpoyeSubMenu.Name = "panelEmpoyeSubMenu";
            this.panelEmpoyeSubMenu.Size = new System.Drawing.Size(200, 134);
            this.panelEmpoyeSubMenu.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nurse";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Receptionist";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctor.Location = new System.Drawing.Point(0, 0);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(200, 23);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnEmploye
            // 
            this.btnEmploye.AllowDrop = true;
            this.btnEmploye.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmploye.Location = new System.Drawing.Point(0, 30);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(200, 30);
            this.btnEmploye.TabIndex = 1;
            this.btnEmploye.Text = "Manage Employe";
            this.btnEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploye.UseVisualStyleBackColor = false;
            this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdminDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(200, 30);
            this.btnAdminDashboard.TabIndex = 0;
            this.btnAdminDashboard.Text = "Dashboard";
            this.btnAdminDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminDashboard.UseVisualStyleBackColor = false;
            // 
            // panelAdminHeader
            // 
            this.panelAdminHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelAdminHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAdminHeader.Name = "panelAdminHeader";
            this.panelAdminHeader.Size = new System.Drawing.Size(923, 47);
            this.panelAdminHeader.TabIndex = 1;
            // 
            // panelAdminMain
            // 
            this.panelAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminMain.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelAdminMain.Location = new System.Drawing.Point(200, 47);
            this.panelAdminMain.Name = "panelAdminMain";
            this.panelAdminMain.Size = new System.Drawing.Size(723, 489);
            this.panelAdminMain.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 536);
            this.Controls.Add(this.panelAdminMain);
            this.Controls.Add(this.panelAdminLeft);
            this.Controls.Add(this.panelAdminHeader);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panelAdminLeft.ResumeLayout(false);
            this.panelEmpoyeSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminLeft;
        private System.Windows.Forms.Panel panelAdminHeader;
        private System.Windows.Forms.Panel panelAdminMain;
        private System.Windows.Forms.Button btnEmploye;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Panel panelEmpoyeSubMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDoctor;
    }
}