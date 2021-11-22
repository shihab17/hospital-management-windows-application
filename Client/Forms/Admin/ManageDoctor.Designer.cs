
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDentist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDutyDoctor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSurgeon = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.panelMangeDoctorButtom.SuspendLayout();
            this.panelManageDoctorMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMangeDoctorButtom
            // 
            this.panelMangeDoctorButtom.BackColor = System.Drawing.Color.Teal;
            this.panelMangeDoctorButtom.Controls.Add(this.btnViewDoctor);
            this.panelMangeDoctorButtom.Controls.Add(this.btnAddDoctor);
            this.panelMangeDoctorButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMangeDoctorButtom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelMangeDoctorButtom.Location = new System.Drawing.Point(0, 449);
            this.panelMangeDoctorButtom.Name = "panelMangeDoctorButtom";
            this.panelMangeDoctorButtom.Size = new System.Drawing.Size(795, 50);
            this.panelMangeDoctorButtom.TabIndex = 0;
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewDoctor.Location = new System.Drawing.Point(254, 16);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(114, 28);
            this.btnViewDoctor.TabIndex = 1;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = false;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click_1);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddDoctor.Location = new System.Drawing.Point(100, 15);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(106, 31);
            this.btnAddDoctor.TabIndex = 0;
            this.btnAddDoctor.Text = "Add New Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // panelManageDoctorMain
            // 
            this.panelManageDoctorMain.Controls.Add(this.panel3);
            this.panelManageDoctorMain.Controls.Add(this.panel2);
            this.panelManageDoctorMain.Controls.Add(this.panel1);
            this.panelManageDoctorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageDoctorMain.Location = new System.Drawing.Point(0, 0);
            this.panelManageDoctorMain.Name = "panelManageDoctorMain";
            this.panelManageDoctorMain.Size = new System.Drawing.Size(795, 449);
            this.panelManageDoctorMain.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.labelDentist);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(556, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 150);
            this.panel3.TabIndex = 5;
            // 
            // labelDentist
            // 
            this.labelDentist.AutoSize = true;
            this.labelDentist.Location = new System.Drawing.Point(89, 73);
            this.labelDentist.Name = "labelDentist";
            this.labelDentist.Size = new System.Drawing.Size(31, 36);
            this.labelDentist.TabIndex = 1;
            this.labelDentist.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Dentist";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.labelDutyDoctor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(296, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 4;
            // 
            // labelDutyDoctor
            // 
            this.labelDutyDoctor.AutoSize = true;
            this.labelDutyDoctor.Location = new System.Drawing.Point(89, 73);
            this.labelDutyDoctor.Name = "labelDutyDoctor";
            this.labelDutyDoctor.Size = new System.Drawing.Size(31, 36);
            this.labelDutyDoctor.TabIndex = 1;
            this.labelDutyDoctor.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Duty Doctor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.labelSurgeon);
            this.panel1.Controls.Add(this.labelT);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(38, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 150);
            this.panel1.TabIndex = 3;
            // 
            // labelSurgeon
            // 
            this.labelSurgeon.AutoSize = true;
            this.labelSurgeon.Location = new System.Drawing.Point(89, 73);
            this.labelSurgeon.Name = "labelSurgeon";
            this.labelSurgeon.Size = new System.Drawing.Size(31, 36);
            this.labelSurgeon.TabIndex = 1;
            this.labelSurgeon.Text = "0";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelT.Location = new System.Drawing.Point(39, 24);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(152, 28);
            this.labelT.TabIndex = 0;
            this.labelT.Text = "Total Surgeon";
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMangeDoctorButtom;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Panel panelManageDoctorMain;
        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDentist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDutyDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSurgeon;
        private System.Windows.Forms.Label labelT;
    }
}