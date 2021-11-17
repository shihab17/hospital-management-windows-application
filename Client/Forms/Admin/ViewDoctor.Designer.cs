
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class ViewDoctor
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
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoctorFirstName = new System.Windows.Forms.TextBox();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.txtDoctorEmail = new System.Windows.Forms.TextBox();
            this.txtDoctorPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtDocotorfees = new System.Windows.Forms.TextBox();
            this.txtDoctorUserId = new System.Windows.Forms.TextBox();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.btnDoctorUpdate = new System.Windows.Forms.Button();
            this.cbDoctorRoom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDoctorTime = new System.Windows.Forms.ComboBox();
            this.clbDoctorDay = new System.Windows.Forms.CheckedListBox();
            this.cbDoctorSpeciality = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtDoctorJoinDate = new System.Windows.Forms.TextBox();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.panelView.SuspendLayout();
            this.panelData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToOrderColumns = true;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Location = new System.Drawing.Point(12, 6);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.RowTemplate.Height = 25;
            this.dgvDoctor.Size = new System.Drawing.Size(876, 217);
            this.dgvDoctor.TabIndex = 0;
            this.dgvDoctor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctor_CellMouseDoubleClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-211, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // txtDoctorFirstName
            // 
            this.txtDoctorFirstName.Location = new System.Drawing.Point(229, 6);
            this.txtDoctorFirstName.Name = "txtDoctorFirstName";
            this.txtDoctorFirstName.Size = new System.Drawing.Size(180, 23);
            this.txtDoctorFirstName.TabIndex = 3;
            // 
            // txtDoctorLastName
            // 
            this.txtDoctorLastName.Location = new System.Drawing.Point(446, 6);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(180, 23);
            this.txtDoctorLastName.TabIndex = 4;
            // 
            // txtDoctorEmail
            // 
            this.txtDoctorEmail.Location = new System.Drawing.Point(19, 55);
            this.txtDoctorEmail.Name = "txtDoctorEmail";
            this.txtDoctorEmail.Size = new System.Drawing.Size(180, 23);
            this.txtDoctorEmail.TabIndex = 5;
            // 
            // txtDoctorPhoneNumber
            // 
            this.txtDoctorPhoneNumber.Location = new System.Drawing.Point(229, 55);
            this.txtDoctorPhoneNumber.Name = "txtDoctorPhoneNumber";
            this.txtDoctorPhoneNumber.Size = new System.Drawing.Size(180, 23);
            this.txtDoctorPhoneNumber.TabIndex = 6;
            // 
            // txtDocotorfees
            // 
            this.txtDocotorfees.Location = new System.Drawing.Point(446, 99);
            this.txtDocotorfees.Name = "txtDocotorfees";
            this.txtDocotorfees.Size = new System.Drawing.Size(180, 23);
            this.txtDocotorfees.TabIndex = 10;
            // 
            // txtDoctorUserId
            // 
            this.txtDoctorUserId.Location = new System.Drawing.Point(19, 3);
            this.txtDoctorUserId.Name = "txtDoctorUserId";
            this.txtDoctorUserId.Size = new System.Drawing.Size(180, 23);
            this.txtDoctorUserId.TabIndex = 13;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.dgvDoctor);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(900, 229);
            this.panelView.TabIndex = 16;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.btnDoctorDelete);
            this.panelData.Controls.Add(this.btnDoctorUpdate);
            this.panelData.Controls.Add(this.cbDoctorRoom);
            this.panelData.Controls.Add(this.groupBox2);
            this.panelData.Controls.Add(this.cbDoctorSpeciality);
            this.panelData.Controls.Add(this.groupBox1);
            this.panelData.Controls.Add(this.txtDoctorJoinDate);
            this.panelData.Controls.Add(this.txtDoctorPhoneNumber);
            this.panelData.Controls.Add(this.txtDoctorFirstName);
            this.panelData.Controls.Add(this.txtDoctorLastName);
            this.panelData.Controls.Add(this.txtDoctorEmail);
            this.panelData.Controls.Add(this.txtDoctorUserId);
            this.panelData.Controls.Add(this.txtDocotorfees);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 229);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(900, 378);
            this.panelData.TabIndex = 17;
            // 
            // btnDoctorUpdate
            // 
            this.btnDoctorUpdate.Location = new System.Drawing.Point(670, 152);
            this.btnDoctorUpdate.Name = "btnDoctorUpdate";
            this.btnDoctorUpdate.Size = new System.Drawing.Size(91, 34);
            this.btnDoctorUpdate.TabIndex = 20;
            this.btnDoctorUpdate.Text = "Update";
            this.btnDoctorUpdate.UseVisualStyleBackColor = true;
            this.btnDoctorUpdate.Click += new System.EventHandler(this.btnDoctorUpdate_Click);
            // 
            // cbDoctorRoom
            // 
            this.cbDoctorRoom.FormattingEnabled = true;
            this.cbDoctorRoom.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "201",
            "202",
            "203"});
            this.cbDoctorRoom.Location = new System.Drawing.Point(670, 98);
            this.cbDoctorRoom.Name = "cbDoctorRoom";
            this.cbDoctorRoom.Size = new System.Drawing.Size(180, 23);
            this.cbDoctorRoom.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDoctorTime);
            this.groupBox2.Controls.Add(this.clbDoctorDay);
            this.groupBox2.Location = new System.Drawing.Point(19, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 155);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // cbDoctorTime
            // 
            this.cbDoctorTime.FormattingEnabled = true;
            this.cbDoctorTime.Items.AddRange(new object[] {
            "9 am- 4 pm",
            "4 pm - 11 pm"});
            this.cbDoctorTime.Location = new System.Drawing.Point(210, 14);
            this.cbDoctorTime.Name = "cbDoctorTime";
            this.cbDoctorTime.Size = new System.Drawing.Size(180, 23);
            this.cbDoctorTime.TabIndex = 1;
            // 
            // clbDoctorDay
            // 
            this.clbDoctorDay.FormattingEnabled = true;
            this.clbDoctorDay.Items.AddRange(new object[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            this.clbDoctorDay.Location = new System.Drawing.Point(7, 15);
            this.clbDoctorDay.Name = "clbDoctorDay";
            this.clbDoctorDay.Size = new System.Drawing.Size(173, 130);
            this.clbDoctorDay.TabIndex = 0;
            // 
            // cbDoctorSpeciality
            // 
            this.cbDoctorSpeciality.FormattingEnabled = true;
            this.cbDoctorSpeciality.Items.AddRange(new object[] {
            "Surgeon",
            "Paramedic",
            "Psychologist",
            "Consulting doctor",
            "Attending doctor",
            "Duty doctor",
            "Dentist"});
            this.cbDoctorSpeciality.Location = new System.Drawing.Point(446, 55);
            this.cbDoctorSpeciality.Name = "cbDoctorSpeciality";
            this.cbDoctorSpeciality.Size = new System.Drawing.Size(180, 23);
            this.cbDoctorSpeciality.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(670, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 42);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(100, 13);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 13);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtDoctorJoinDate
            // 
            this.txtDoctorJoinDate.Location = new System.Drawing.Point(670, 55);
            this.txtDoctorJoinDate.Name = "txtDoctorJoinDate";
            this.txtDoctorJoinDate.Size = new System.Drawing.Size(180, 23);
            this.txtDoctorJoinDate.TabIndex = 15;
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.Location = new System.Drawing.Point(670, 195);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDoctorDelete.TabIndex = 21;
            this.btnDoctorDelete.Text = "Delete";
            this.btnDoctorDelete.UseVisualStyleBackColor = true;
            this.btnDoctorDelete.Click += new System.EventHandler(this.btnDoctorDelete_Click);
            // 
            // ViewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDoctor";
            this.Text = "ViewDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.panelView.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorFirstName;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.TextBox txtDoctorEmail;
        private System.Windows.Forms.TextBox txtDoctorPhoneNumber;
        private System.Windows.Forms.TextBox txtDocotorfees;
        private System.Windows.Forms.TextBox txtDoctorUserId;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox txtDoctorJoinDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbDoctorSpeciality;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbDoctorDay;
        private System.Windows.Forms.ComboBox cbDoctorTime;
        private System.Windows.Forms.ComboBox cbDoctorRoom;
        private System.Windows.Forms.Button btnDoctorUpdate;
        private System.Windows.Forms.Button btnDoctorDelete;
    }
}