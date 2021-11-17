
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class ManageDoctor
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
            this.panelMangeDoctorButtom = new System.Windows.Forms.Panel();
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.panelManageDoctorMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMangeDoctorButtom.SuspendLayout();
            this.panelManageDoctorMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMangeDoctorButtom
            // 
            this.panelMangeDoctorButtom.Controls.Add(this.btnViewDoctor);
            this.panelMangeDoctorButtom.Controls.Add(this.btnAddDoctor);
            this.panelMangeDoctorButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMangeDoctorButtom.Location = new System.Drawing.Point(0, 441);
            this.panelMangeDoctorButtom.Name = "panelMangeDoctorButtom";
            this.panelMangeDoctorButtom.Size = new System.Drawing.Size(795, 58);
            this.panelMangeDoctorButtom.TabIndex = 0;
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.Location = new System.Drawing.Point(340, 15);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(114, 28);
            this.btnViewDoctor.TabIndex = 1;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = true;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click_1);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(100, 18);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(114, 28);
            this.btnAddDoctor.TabIndex = 0;
            this.btnAddDoctor.Text = "Add New Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // panelManageDoctorMain
            // 
            this.panelManageDoctorMain.Controls.Add(this.label1);
            this.panelManageDoctorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageDoctorMain.Location = new System.Drawing.Point(0, 0);
            this.panelManageDoctorMain.Name = "panelManageDoctorMain";
            this.panelManageDoctorMain.Size = new System.Drawing.Size(795, 441);
            this.panelManageDoctorMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Doctor ";
            // 
            // ManageDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(795, 499);
            this.Controls.Add(this.panelManageDoctorMain);
            this.Controls.Add(this.panelMangeDoctorButtom);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDoctor";
            this.Text = "ManageDoctor";
            this.panelMangeDoctorButtom.ResumeLayout(false);
            this.panelManageDoctorMain.ResumeLayout(false);
            this.panelManageDoctorMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMangeDoctorButtom;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Panel panelManageDoctorMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDoctor;
    }
}