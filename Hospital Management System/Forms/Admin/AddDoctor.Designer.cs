
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class AddDoctor
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
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocotorFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.txtDoctorPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoctorEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAddEmplyee = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoctorUserId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoctorPassword = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnAddNewDoctor = new System.Windows.Forms.Button();
            this.panelDoctor = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clbDoctorSchedeule = new System.Windows.Forms.CheckedListBox();
            this.cbDoctorSchedule = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDoctorRoom = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDocotrFees = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDoctorSpeciality = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelAddEmplyee.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelDoctor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.panelUser);
            this.panelLeft.Controls.Add(this.panelAddEmplyee);
            this.panelLeft.Controls.Add(this.btnNext);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(453, 485);
            this.panelLeft.TabIndex = 16;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.Control;
            this.panelUser.Controls.Add(this.groupBox1);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Controls.Add(this.txtDocotorFirstName);
            this.panelUser.Controls.Add(this.label2);
            this.panelUser.Controls.Add(this.txtDoctorLastName);
            this.panelUser.Controls.Add(this.txtDoctorPhoneNumber);
            this.panelUser.Controls.Add(this.label6);
            this.panelUser.Controls.Add(this.label4);
            this.panelUser.Controls.Add(this.txtDoctorEmail);
            this.panelUser.Controls.Add(this.label5);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelUser.Location = new System.Drawing.Point(0, 100);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(453, 224);
            this.panelUser.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Location = new System.Drawing.Point(91, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 48);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 21);
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
            this.rbFemale.Location = new System.Drawing.Point(129, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(69, 21);
            this.rbFemale.TabIndex = 26;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name";
            // 
            // txtDocotorFirstName
            // 
            this.txtDocotorFirstName.Location = new System.Drawing.Point(91, 12);
            this.txtDocotorFirstName.Name = "txtDocotorFirstName";
            this.txtDocotorFirstName.Size = new System.Drawing.Size(226, 25);
            this.txtDocotorFirstName.TabIndex = 17;
            this.txtDocotorFirstName.TextChanged += new System.EventHandler(this.txtDocotorFirstName_TextChanged);
            this.txtDocotorFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocotorFirstName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name";
            // 
            // txtDoctorLastName
            // 
            this.txtDoctorLastName.Location = new System.Drawing.Point(91, 58);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(226, 25);
            this.txtDoctorLastName.TabIndex = 19;
            this.txtDoctorLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDoctorLastName_Validating);
            // 
            // txtDoctorPhoneNumber
            // 
            this.txtDoctorPhoneNumber.Location = new System.Drawing.Point(91, 188);
            this.txtDoctorPhoneNumber.Name = "txtDoctorPhoneNumber";
            this.txtDoctorPhoneNumber.Size = new System.Drawing.Size(226, 25);
            this.txtDoctorPhoneNumber.TabIndex = 24;
            this.txtDoctorPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtDoctorPhoneNumber_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gender";
            // 
            // txtDoctorEmail
            // 
            this.txtDoctorEmail.Location = new System.Drawing.Point(91, 143);
            this.txtDoctorEmail.Name = "txtDoctorEmail";
            this.txtDoctorEmail.Size = new System.Drawing.Size(226, 25);
            this.txtDoctorEmail.TabIndex = 22;
            this.txtDoctorEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtDoctorEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email";
            // 
            // panelAddEmplyee
            // 
            this.panelAddEmplyee.BackColor = System.Drawing.SystemColors.Control;
            this.panelAddEmplyee.Controls.Add(this.btnAddEmployee);
            this.panelAddEmplyee.Controls.Add(this.label3);
            this.panelAddEmplyee.Controls.Add(this.txtDoctorUserId);
            this.panelAddEmplyee.Controls.Add(this.label7);
            this.panelAddEmplyee.Controls.Add(this.txtDoctorPassword);
            this.panelAddEmplyee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddEmplyee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAddEmplyee.Location = new System.Drawing.Point(0, 0);
            this.panelAddEmplyee.Name = "panelAddEmplyee";
            this.panelAddEmplyee.Size = new System.Drawing.Size(453, 100);
            this.panelAddEmplyee.TabIndex = 17;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.Location = new System.Drawing.Point(337, 45);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 37);
            this.btnAddEmployee.TabIndex = 24;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "User Id";
            // 
            // txtDoctorUserId
            // 
            this.txtDoctorUserId.Location = new System.Drawing.Point(91, 17);
            this.txtDoctorUserId.Name = "txtDoctorUserId";
            this.txtDoctorUserId.Size = new System.Drawing.Size(226, 25);
            this.txtDoctorUserId.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Password";
            // 
            // txtDoctorPassword
            // 
            this.txtDoctorPassword.Location = new System.Drawing.Point(91, 63);
            this.txtDoctorPassword.Name = "txtDoctorPassword";
            this.txtDoctorPassword.Size = new System.Drawing.Size(226, 25);
            this.txtDoctorPassword.TabIndex = 23;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(168, 344);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 33);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.btnAddNewDoctor);
            this.panelRight.Controls.Add(this.panelDoctor);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelRight.Location = new System.Drawing.Point(459, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(593, 485);
            this.panelRight.TabIndex = 17;
            // 
            // btnAddNewDoctor
            // 
            this.btnAddNewDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNewDoctor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewDoctor.Location = new System.Drawing.Point(120, 344);
            this.btnAddNewDoctor.Name = "btnAddNewDoctor";
            this.btnAddNewDoctor.Size = new System.Drawing.Size(115, 33);
            this.btnAddNewDoctor.TabIndex = 3;
            this.btnAddNewDoctor.Text = "Add Doctor";
            this.btnAddNewDoctor.UseVisualStyleBackColor = false;
            this.btnAddNewDoctor.Click += new System.EventHandler(this.btnAddNewDoctor_Click);
            // 
            // panelDoctor
            // 
            this.panelDoctor.BackColor = System.Drawing.SystemColors.Control;
            this.panelDoctor.Controls.Add(this.groupBox2);
            this.panelDoctor.Controls.Add(this.cbDoctorRoom);
            this.panelDoctor.Controls.Add(this.label13);
            this.panelDoctor.Controls.Add(this.txtDocotrFees);
            this.panelDoctor.Controls.Add(this.label12);
            this.panelDoctor.Controls.Add(this.label8);
            this.panelDoctor.Controls.Add(this.label9);
            this.panelDoctor.Controls.Add(this.cbDoctorSpeciality);
            this.panelDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctor.Location = new System.Drawing.Point(0, 0);
            this.panelDoctor.Name = "panelDoctor";
            this.panelDoctor.Size = new System.Drawing.Size(593, 324);
            this.panelDoctor.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.clbDoctorSchedeule);
            this.groupBox2.Controls.Add(this.cbDoctorSchedule);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(86, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 191);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Time";
            // 
            // clbDoctorSchedeule
            // 
            this.clbDoctorSchedeule.FormattingEnabled = true;
            this.clbDoctorSchedeule.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.clbDoctorSchedeule.Location = new System.Drawing.Point(11, 39);
            this.clbDoctorSchedeule.Name = "clbDoctorSchedeule";
            this.clbDoctorSchedeule.Size = new System.Drawing.Size(100, 124);
            this.clbDoctorSchedeule.TabIndex = 4;
            // 
            // cbDoctorSchedule
            // 
            this.cbDoctorSchedule.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDoctorSchedule.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDoctorSchedule.FormattingEnabled = true;
            this.cbDoctorSchedule.Items.AddRange(new object[] {
            "9 am- 4 pm",
            "4 pm - 11 pm"});
            this.cbDoctorSchedule.Location = new System.Drawing.Point(162, 39);
            this.cbDoctorSchedule.Name = "cbDoctorSchedule";
            this.cbDoctorSchedule.Size = new System.Drawing.Size(121, 25);
            this.cbDoctorSchedule.TabIndex = 5;
            this.cbDoctorSchedule.SelectedIndexChanged += new System.EventHandler(this.cbDoctorSchedule_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Day";
            // 
            // cbDoctorRoom
            // 
            this.cbDoctorRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDoctorRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDoctorRoom.FormattingEnabled = true;
            this.cbDoctorRoom.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "201",
            "202",
            "203"});
            this.cbDoctorRoom.Location = new System.Drawing.Point(86, 288);
            this.cbDoctorRoom.Name = "cbDoctorRoom";
            this.cbDoctorRoom.Size = new System.Drawing.Size(208, 25);
            this.cbDoctorRoom.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Room No";
            // 
            // txtDocotrFees
            // 
            this.txtDocotrFees.Location = new System.Drawing.Point(86, 246);
            this.txtDocotrFees.Name = "txtDocotrFees";
            this.txtDocotrFees.Size = new System.Drawing.Size(208, 25);
            this.txtDocotrFees.TabIndex = 9;
            this.txtDocotrFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocotrFees_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Fees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Speciality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Schedule";
            // 
            // cbDoctorSpeciality
            // 
            this.cbDoctorSpeciality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDoctorSpeciality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDoctorSpeciality.FormattingEnabled = true;
            this.cbDoctorSpeciality.Items.AddRange(new object[] {
            "Surgeon",
            "Paramedic",
            "Psychologist",
            "Consulting doctor",
            "Attending doctor",
            "Duty doctor",
            "Dentist"});
            this.cbDoctorSpeciality.Location = new System.Drawing.Point(86, 17);
            this.cbDoctorSpeciality.Name = "cbDoctorSpeciality";
            this.cbDoctorSpeciality.Size = new System.Drawing.Size(208, 25);
            this.cbDoctorSpeciality.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(453, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 485);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDoctor";
            this.Text = "First Name";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAddEmplyee.ResumeLayout(false);
            this.panelAddEmplyee.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelDoctor.ResumeLayout(false);
            this.panelDoctor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtDocotorFirstName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.TextBox txtDoctorPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoctorEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelAddEmplyee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctorUserId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoctorPassword;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDoctorSpeciality;
        private System.Windows.Forms.ComboBox cbDoctorSchedule;
        private System.Windows.Forms.CheckedListBox clbDoctorSchedeule;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddNewDoctor;
        private System.Windows.Forms.ComboBox cbDoctorRoom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDocotrFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
    }
}