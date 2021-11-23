
namespace Hospital_Management_System.Client.Forms.Receptionist
{
    partial class ViewAppointment
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
            this.panelAppointmentView = new System.Windows.Forms.Panel();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.panelAppointmentData = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.btnAppointmentDelete = new System.Windows.Forms.Button();
            this.btnAppointmentUpdate = new System.Windows.Forms.Button();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAppointmentDate = new System.Windows.Forms.TextBox();
            this.panelAppointmentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.panelAppointmentData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAppointmentView
            // 
            this.panelAppointmentView.Controls.Add(this.dgvAppointment);
            this.panelAppointmentView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppointmentView.Location = new System.Drawing.Point(0, 0);
            this.panelAppointmentView.Margin = new System.Windows.Forms.Padding(4);
            this.panelAppointmentView.Name = "panelAppointmentView";
            this.panelAppointmentView.Size = new System.Drawing.Size(1024, 290);
            this.panelAppointmentView.TabIndex = 0;
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(17, 49);
            this.dgvAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowTemplate.Height = 25;
            this.dgvAppointment.Size = new System.Drawing.Size(972, 210);
            this.dgvAppointment.TabIndex = 0;
            this.dgvAppointment.DoubleClick += new System.EventHandler(this.dgvAppointment_DoubleClick);
            // 
            // panelAppointmentData
            // 
            this.panelAppointmentData.Controls.Add(this.groupBox1);
            this.panelAppointmentData.Controls.Add(this.txtAppointmentId);
            this.panelAppointmentData.Controls.Add(this.btnAppointmentDelete);
            this.panelAppointmentData.Controls.Add(this.btnAppointmentUpdate);
            this.panelAppointmentData.Controls.Add(this.cbDoctorName);
            this.panelAppointmentData.Controls.Add(this.txtAge);
            this.panelAppointmentData.Controls.Add(this.txtName);
            this.panelAppointmentData.Controls.Add(this.txtAppointmentDate);
            this.panelAppointmentData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppointmentData.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAppointmentData.Location = new System.Drawing.Point(0, 290);
            this.panelAppointmentData.Margin = new System.Windows.Forms.Padding(4);
            this.panelAppointmentData.Name = "panelAppointmentData";
            this.panelAppointmentData.Size = new System.Drawing.Size(1024, 305);
            this.panelAppointmentData.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Location = new System.Drawing.Point(296, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(223, 87);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(0, 43);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 21);
            this.rbMale.TabIndex = 25;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(124, 43);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(69, 21);
            this.rbFemale.TabIndex = 26;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Location = new System.Drawing.Point(17, 57);
            this.txtAppointmentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(221, 25);
            this.txtAppointmentId.TabIndex = 13;
            // 
            // btnAppointmentDelete
            // 
            this.btnAppointmentDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAppointmentDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAppointmentDelete.Location = new System.Drawing.Point(880, 140);
            this.btnAppointmentDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointmentDelete.Name = "btnAppointmentDelete";
            this.btnAppointmentDelete.Size = new System.Drawing.Size(109, 52);
            this.btnAppointmentDelete.TabIndex = 12;
            this.btnAppointmentDelete.Text = "Delete";
            this.btnAppointmentDelete.UseVisualStyleBackColor = false;
            this.btnAppointmentDelete.Click += new System.EventHandler(this.btnAppointmentDelete_Click);
            // 
            // btnAppointmentUpdate
            // 
            this.btnAppointmentUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAppointmentUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAppointmentUpdate.Location = new System.Drawing.Point(880, 57);
            this.btnAppointmentUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointmentUpdate.Name = "btnAppointmentUpdate";
            this.btnAppointmentUpdate.Size = new System.Drawing.Size(136, 50);
            this.btnAppointmentUpdate.TabIndex = 11;
            this.btnAppointmentUpdate.Text = "Update";
            this.btnAppointmentUpdate.UseVisualStyleBackColor = false;
            this.btnAppointmentUpdate.Click += new System.EventHandler(this.btnAppointmentUpdate_Click);
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.Location = new System.Drawing.Point(577, 140);
            this.cbDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(221, 25);
            this.cbDoctorName.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(17, 140);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(221, 25);
            this.txtAge.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(577, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 25);
            this.txtName.TabIndex = 8;
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(296, 57);
            this.txtAppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(221, 25);
            this.txtAppointmentDate.TabIndex = 7;
            // 
            // ViewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 581);
            this.Controls.Add(this.panelAppointmentData);
            this.Controls.Add(this.panelAppointmentView);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAppointment";
            this.Text = "ViewAppointment";
            this.panelAppointmentView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.panelAppointmentData.ResumeLayout(false);
            this.panelAppointmentData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAppointmentView;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Panel panelAppointmentData;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Button btnAppointmentDelete;
        private System.Windows.Forms.Button btnAppointmentUpdate;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAppointmentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
    }
}