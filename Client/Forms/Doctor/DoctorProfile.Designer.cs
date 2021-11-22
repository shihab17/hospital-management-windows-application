
namespace Hospital_Management_System.Client.Forms.Doctor
{
    partial class DoctorProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorProfile));
            this.pbDoctor = new System.Windows.Forms.PictureBox();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.labelSchedeule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelJoinDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDoctor
            // 
            this.pbDoctor.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbDoctor.InitialImage")));
            this.pbDoctor.Location = new System.Drawing.Point(43, 43);
            this.pbDoctor.Name = "pbDoctor";
            this.pbDoctor.Size = new System.Drawing.Size(150, 150);
            this.pbDoctor.TabIndex = 0;
            this.pbDoctor.TabStop = false;
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelDoctorName.Location = new System.Drawing.Point(232, 43);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(223, 31);
            this.labelDoctorName.TabIndex = 1;
            this.labelDoctorName.Text = "Doctor Full Name";
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeciality.Location = new System.Drawing.Point(232, 95);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(82, 21);
            this.labelSpeciality.TabIndex = 2;
            this.labelSpeciality.Text = "Speciality";
            // 
            // labelSchedeule
            // 
            this.labelSchedeule.AutoSize = true;
            this.labelSchedeule.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSchedeule.Location = new System.Drawing.Point(232, 134);
            this.labelSchedeule.Name = "labelSchedeule";
            this.labelSchedeule.Size = new System.Drawing.Size(78, 21);
            this.labelSchedeule.TabIndex = 3;
            this.labelSchedeule.Text = "Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserID";
            // 
            // labelJoinDate
            // 
            this.labelJoinDate.AutoSize = true;
            this.labelJoinDate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJoinDate.Location = new System.Drawing.Point(236, 172);
            this.labelJoinDate.Name = "labelJoinDate";
            this.labelJoinDate.Size = new System.Drawing.Size(79, 21);
            this.labelJoinDate.TabIndex = 5;
            this.labelJoinDate.Text = "Join Date";
            // 
            // DoctorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJoinDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSchedeule);
            this.Controls.Add(this.labelSpeciality);
            this.Controls.Add(this.labelDoctorName);
            this.Controls.Add(this.pbDoctor);
            this.Name = "DoctorProfile";
            this.Text = "Doctor Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDoctor;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.Label labelSchedeule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelJoinDate;
    }
}