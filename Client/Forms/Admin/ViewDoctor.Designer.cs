
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
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
            this.dgvDoctor.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.GridColor = System.Drawing.Color.Teal;
            this.dgvDoctor.Location = new System.Drawing.Point(12, 6);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.RowTemplate.Height = 25;
            this.dgvDoctor.Size = new System.Drawing.Size(668, 217);
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
            this.txtDoctorFirstName.Location = new System.Drawing.Point(229, 32);
            this.txtDoctorFirstName.Name = "txtDoctorFirstName";
            this.txtDoctorFirstName.Size = new System.Drawing.Size(180, 29);
            this.txtDoctorFirstName.TabIndex = 3;
            // 
            // txtDoctorLastName
            // 
            this.txtDoctorLastName.Location = new System.Drawing.Point(442, 32);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(180, 29);
            this.txtDoctorLastName.TabIndex = 4;
            // 
            // txtDoctorEmail
            // 
            this.txtDoctorEmail.Location = new System.Drawing.Point(230, 104);
            this.txtDoctorEmail.Name = "txtDoctorEmail";
            this.txtDoctorEmail.Size = new System.Drawing.Size(180, 29);
            this.txtDoctorEmail.TabIndex = 5;
            // 
            // txtDoctorPhoneNumber
            // 
            this.txtDoctorPhoneNumber.Location = new System.Drawing.Point(442, 108);
            this.txtDoctorPhoneNumber.Name = "txtDoctorPhoneNumber";
            this.txtDoctorPhoneNumber.Size = new System.Drawing.Size(180, 29);
            this.txtDoctorPhoneNumber.TabIndex = 6;
            // 
            // txtDocotorfees
            // 
            this.txtDocotorfees.Location = new System.Drawing.Point(442, 165);
            this.txtDocotorfees.Name = "txtDocotorfees";
            this.txtDocotorfees.Size = new System.Drawing.Size(180, 29);
            this.txtDocotorfees.TabIndex = 10;
            // 
            // txtDoctorUserId
            // 
            this.txtDoctorUserId.Location = new System.Drawing.Point(33, 32);
            this.txtDoctorUserId.Name = "txtDoctorUserId";
            this.txtDoctorUserId.Size = new System.Drawing.Size(180, 29);
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
            this.panelData.Controls.Add(this.label11);
            this.panelData.Controls.Add(this.label10);
            this.panelData.Controls.Add(this.label9);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label1);
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
            this.panelData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelData.Location = new System.Drawing.Point(0, 229);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(900, 378);
            this.panelData.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Fees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Join Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Room No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Spaciality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Doctor Id";
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoctorDelete.Location = new System.Drawing.Point(501, 295);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDoctorDelete.TabIndex = 21;
            this.btnDoctorDelete.Text = "Delete";
            this.btnDoctorDelete.UseVisualStyleBackColor = false;
            this.btnDoctorDelete.Click += new System.EventHandler(this.btnDoctorDelete_Click);
            // 
            // btnDoctorUpdate
            // 
            this.btnDoctorUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoctorUpdate.Location = new System.Drawing.Point(501, 255);
            this.btnDoctorUpdate.Name = "btnDoctorUpdate";
            this.btnDoctorUpdate.Size = new System.Drawing.Size(91, 34);
            this.btnDoctorUpdate.TabIndex = 20;
            this.btnDoctorUpdate.Text = "Update";
            this.btnDoctorUpdate.UseVisualStyleBackColor = false;
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
            this.cbDoctorRoom.Location = new System.Drawing.Point(229, 165);
            this.cbDoctorRoom.Name = "cbDoctorRoom";
            this.cbDoctorRoom.Size = new System.Drawing.Size(180, 29);
            this.cbDoctorRoom.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDoctorTime);
            this.groupBox2.Controls.Add(this.clbDoctorDay);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(35, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 180);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule";
            // 
            // cbDoctorTime
            // 
            this.cbDoctorTime.FormattingEnabled = true;
            this.cbDoctorTime.Items.AddRange(new object[] {
            "9 am- 4 pm",
            "4 pm - 11 pm"});
            this.cbDoctorTime.Location = new System.Drawing.Point(210, 14);
            this.cbDoctorTime.Name = "cbDoctorTime";
            this.cbDoctorTime.Size = new System.Drawing.Size(180, 29);
            this.cbDoctorTime.TabIndex = 1;
            // 
            // clbDoctorDay
            // 
            this.clbDoctorDay.FormattingEnabled = true;
            this.clbDoctorDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.clbDoctorDay.Location = new System.Drawing.Point(6, 15);
            this.clbDoctorDay.Name = "clbDoctorDay";
            this.clbDoctorDay.Size = new System.Drawing.Size(131, 148);
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
            this.cbDoctorSpeciality.Location = new System.Drawing.Point(40, 165);
            this.cbDoctorSpeciality.Name = "cbDoctorSpeciality";
            this.cbDoctorSpeciality.Size = new System.Drawing.Size(180, 29);
            this.cbDoctorSpeciality.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(35, 91);
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
            this.rbFemale.Size = new System.Drawing.Size(81, 25);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 13);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(64, 25);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtDoctorJoinDate
            // 
            this.txtDoctorJoinDate.Location = new System.Drawing.Point(442, 218);
            this.txtDoctorJoinDate.Name = "txtDoctorJoinDate";
            this.txtDoctorJoinDate.Size = new System.Drawing.Size(180, 29);
            this.txtDoctorJoinDate.TabIndex = 15;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}