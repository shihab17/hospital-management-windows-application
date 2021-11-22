
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class ViewRecptionist
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
            this.panelRecptionistView = new System.Windows.Forms.Panel();
            this.dgvRecptionist = new System.Windows.Forms.DataGridView();
            this.panelRecptionistViewData = new System.Windows.Forms.Panel();
            this.btnReceptionistDelete = new System.Windows.Forms.Button();
            this.btnReceptionistUpdate = new System.Windows.Forms.Button();
            this.txtRecetionistJoinDate = new System.Windows.Forms.TextBox();
            this.cbReceptionistSalary = new System.Windows.Forms.ComboBox();
            this.cbReceptionistDutyTime = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtReceptionistPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtReceptionistFirstName = new System.Windows.Forms.TextBox();
            this.txtReceptionistLastName = new System.Windows.Forms.TextBox();
            this.txtReceptionistEmail = new System.Windows.Forms.TextBox();
            this.txtReceptionistUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelRecptionistView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecptionist)).BeginInit();
            this.panelRecptionistViewData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRecptionistView
            // 
            this.panelRecptionistView.Controls.Add(this.dgvRecptionist);
            this.panelRecptionistView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecptionistView.Location = new System.Drawing.Point(0, 0);
            this.panelRecptionistView.Name = "panelRecptionistView";
            this.panelRecptionistView.Size = new System.Drawing.Size(803, 222);
            this.panelRecptionistView.TabIndex = 0;
            // 
            // dgvRecptionist
            // 
            this.dgvRecptionist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecptionist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecptionist.GridColor = System.Drawing.Color.Teal;
            this.dgvRecptionist.Location = new System.Drawing.Point(12, 55);
            this.dgvRecptionist.Name = "dgvRecptionist";
            this.dgvRecptionist.RowTemplate.Height = 25;
            this.dgvRecptionist.Size = new System.Drawing.Size(776, 150);
            this.dgvRecptionist.TabIndex = 0;
            this.dgvRecptionist.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecptionist_CellMouseDoubleClick);
            // 
            // panelRecptionistViewData
            // 
            this.panelRecptionistViewData.Controls.Add(this.label9);
            this.panelRecptionistViewData.Controls.Add(this.label8);
            this.panelRecptionistViewData.Controls.Add(this.label7);
            this.panelRecptionistViewData.Controls.Add(this.label6);
            this.panelRecptionistViewData.Controls.Add(this.label5);
            this.panelRecptionistViewData.Controls.Add(this.label4);
            this.panelRecptionistViewData.Controls.Add(this.label3);
            this.panelRecptionistViewData.Controls.Add(this.label2);
            this.panelRecptionistViewData.Controls.Add(this.label1);
            this.panelRecptionistViewData.Controls.Add(this.btnReceptionistDelete);
            this.panelRecptionistViewData.Controls.Add(this.btnReceptionistUpdate);
            this.panelRecptionistViewData.Controls.Add(this.txtRecetionistJoinDate);
            this.panelRecptionistViewData.Controls.Add(this.cbReceptionistSalary);
            this.panelRecptionistViewData.Controls.Add(this.cbReceptionistDutyTime);
            this.panelRecptionistViewData.Controls.Add(this.groupBox1);
            this.panelRecptionistViewData.Controls.Add(this.txtReceptionistPhoneNumber);
            this.panelRecptionistViewData.Controls.Add(this.txtReceptionistFirstName);
            this.panelRecptionistViewData.Controls.Add(this.txtReceptionistLastName);
            this.panelRecptionistViewData.Controls.Add(this.txtReceptionistEmail);
            this.panelRecptionistViewData.Controls.Add(this.txtReceptionistUserId);
            this.panelRecptionistViewData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecptionistViewData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelRecptionistViewData.Location = new System.Drawing.Point(0, 222);
            this.panelRecptionistViewData.Name = "panelRecptionistViewData";
            this.panelRecptionistViewData.Size = new System.Drawing.Size(803, 216);
            this.panelRecptionistViewData.TabIndex = 1;
            // 
            // btnReceptionistDelete
            // 
            this.btnReceptionistDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReceptionistDelete.Location = new System.Drawing.Point(664, 110);
            this.btnReceptionistDelete.Name = "btnReceptionistDelete";
            this.btnReceptionistDelete.Size = new System.Drawing.Size(75, 35);
            this.btnReceptionistDelete.TabIndex = 28;
            this.btnReceptionistDelete.Text = "Delete";
            this.btnReceptionistDelete.UseVisualStyleBackColor = false;
            this.btnReceptionistDelete.Click += new System.EventHandler(this.btnReceptionistDelete_Click);
            // 
            // btnReceptionistUpdate
            // 
            this.btnReceptionistUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReceptionistUpdate.Location = new System.Drawing.Point(664, 57);
            this.btnReceptionistUpdate.Name = "btnReceptionistUpdate";
            this.btnReceptionistUpdate.Size = new System.Drawing.Size(75, 41);
            this.btnReceptionistUpdate.TabIndex = 27;
            this.btnReceptionistUpdate.Text = "Update";
            this.btnReceptionistUpdate.UseVisualStyleBackColor = false;
            this.btnReceptionistUpdate.Click += new System.EventHandler(this.btnReceptionistUpdate_Click);
            // 
            // txtRecetionistJoinDate
            // 
            this.txtRecetionistJoinDate.Location = new System.Drawing.Point(439, 161);
            this.txtRecetionistJoinDate.Name = "txtRecetionistJoinDate";
            this.txtRecetionistJoinDate.Size = new System.Drawing.Size(180, 29);
            this.txtRecetionistJoinDate.TabIndex = 26;
            // 
            // cbReceptionistSalary
            // 
            this.cbReceptionistSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbReceptionistSalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReceptionistSalary.FormattingEnabled = true;
            this.cbReceptionistSalary.Items.AddRange(new object[] {
            "50000",
            "40000",
            "35000",
            "30000",
            "25000",
            "20000",
            "15000",
            "12000"});
            this.cbReceptionistSalary.Location = new System.Drawing.Point(222, 161);
            this.cbReceptionistSalary.Name = "cbReceptionistSalary";
            this.cbReceptionistSalary.Size = new System.Drawing.Size(163, 29);
            this.cbReceptionistSalary.TabIndex = 9;
            // 
            // cbReceptionistDutyTime
            // 
            this.cbReceptionistDutyTime.FormattingEnabled = true;
            this.cbReceptionistDutyTime.Items.AddRange(new object[] {
            "9 am- 4 pm",
            "4 pm - 11 pm"});
            this.cbReceptionistDutyTime.Location = new System.Drawing.Point(12, 161);
            this.cbReceptionistDutyTime.Name = "cbReceptionistDutyTime";
            this.cbReceptionistDutyTime.Size = new System.Drawing.Size(180, 29);
            this.cbReceptionistDutyTime.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 42);
            this.groupBox1.TabIndex = 24;
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
            this.rbMale.Location = new System.Drawing.Point(7, 13);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(64, 25);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtReceptionistPhoneNumber
            // 
            this.txtReceptionistPhoneNumber.Location = new System.Drawing.Point(439, 101);
            this.txtReceptionistPhoneNumber.Name = "txtReceptionistPhoneNumber";
            this.txtReceptionistPhoneNumber.Size = new System.Drawing.Size(180, 29);
            this.txtReceptionistPhoneNumber.TabIndex = 21;
            // 
            // txtReceptionistFirstName
            // 
            this.txtReceptionistFirstName.Location = new System.Drawing.Point(222, 39);
            this.txtReceptionistFirstName.Name = "txtReceptionistFirstName";
            this.txtReceptionistFirstName.Size = new System.Drawing.Size(180, 29);
            this.txtReceptionistFirstName.TabIndex = 18;
            // 
            // txtReceptionistLastName
            // 
            this.txtReceptionistLastName.Location = new System.Drawing.Point(439, 39);
            this.txtReceptionistLastName.Name = "txtReceptionistLastName";
            this.txtReceptionistLastName.Size = new System.Drawing.Size(180, 29);
            this.txtReceptionistLastName.TabIndex = 19;
            // 
            // txtReceptionistEmail
            // 
            this.txtReceptionistEmail.Location = new System.Drawing.Point(222, 101);
            this.txtReceptionistEmail.Name = "txtReceptionistEmail";
            this.txtReceptionistEmail.Size = new System.Drawing.Size(180, 29);
            this.txtReceptionistEmail.TabIndex = 20;
            // 
            // txtReceptionistUserId
            // 
            this.txtReceptionistUserId.Location = new System.Drawing.Point(12, 39);
            this.txtReceptionistUserId.Name = "txtReceptionistUserId";
            this.txtReceptionistUserId.Size = new System.Drawing.Size(180, 29);
            this.txtReceptionistUserId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Receptionist Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Duty Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Join Date";
            // 
            // ViewRecptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.panelRecptionistViewData);
            this.Controls.Add(this.panelRecptionistView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewRecptionist";
            this.Text = "ViewRecptionist";
            this.panelRecptionistView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecptionist)).EndInit();
            this.panelRecptionistViewData.ResumeLayout(false);
            this.panelRecptionistViewData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecptionistView;
        private System.Windows.Forms.DataGridView dgvRecptionist;
        private System.Windows.Forms.Panel panelRecptionistViewData;
        private System.Windows.Forms.ComboBox cbReceptionistDutyTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtReceptionistPhoneNumber;
        private System.Windows.Forms.TextBox txtReceptionistFirstName;
        private System.Windows.Forms.TextBox txtReceptionistLastName;
        private System.Windows.Forms.TextBox txtReceptionistEmail;
        private System.Windows.Forms.TextBox txtReceptionistUserId;
        private System.Windows.Forms.ComboBox cbReceptionistSalary;
        private System.Windows.Forms.Button btnReceptionistDelete;
        private System.Windows.Forms.Button btnReceptionistUpdate;
        private System.Windows.Forms.TextBox txtRecetionistJoinDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}