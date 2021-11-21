
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
            this.dgvRecptionist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecptionist.Location = new System.Drawing.Point(12, 55);
            this.dgvRecptionist.Name = "dgvRecptionist";
            this.dgvRecptionist.RowTemplate.Height = 25;
            this.dgvRecptionist.Size = new System.Drawing.Size(776, 150);
            this.dgvRecptionist.TabIndex = 0;
            this.dgvRecptionist.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecptionist_CellMouseDoubleClick);
            // 
            // panelRecptionistViewData
            // 
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
            this.panelRecptionistViewData.Location = new System.Drawing.Point(0, 222);
            this.panelRecptionistViewData.Name = "panelRecptionistViewData";
            this.panelRecptionistViewData.Size = new System.Drawing.Size(803, 216);
            this.panelRecptionistViewData.TabIndex = 1;
            // 
            // btnReceptionistDelete
            // 
            this.btnReceptionistDelete.Location = new System.Drawing.Point(664, 110);
            this.btnReceptionistDelete.Name = "btnReceptionistDelete";
            this.btnReceptionistDelete.Size = new System.Drawing.Size(75, 23);
            this.btnReceptionistDelete.TabIndex = 28;
            this.btnReceptionistDelete.Text = "Delete";
            this.btnReceptionistDelete.UseVisualStyleBackColor = true;
            this.btnReceptionistDelete.Click += new System.EventHandler(this.btnReceptionistDelete_Click);
            // 
            // btnReceptionistUpdate
            // 
            this.btnReceptionistUpdate.Location = new System.Drawing.Point(664, 57);
            this.btnReceptionistUpdate.Name = "btnReceptionistUpdate";
            this.btnReceptionistUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnReceptionistUpdate.TabIndex = 27;
            this.btnReceptionistUpdate.Text = "Update";
            this.btnReceptionistUpdate.UseVisualStyleBackColor = true;
            this.btnReceptionistUpdate.Click += new System.EventHandler(this.btnReceptionistUpdate_Click);
            // 
            // txtRecetionistJoinDate
            // 
            this.txtRecetionistJoinDate.Location = new System.Drawing.Point(439, 110);
            this.txtRecetionistJoinDate.Name = "txtRecetionistJoinDate";
            this.txtRecetionistJoinDate.Size = new System.Drawing.Size(180, 23);
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
            this.cbReceptionistSalary.Location = new System.Drawing.Point(222, 110);
            this.cbReceptionistSalary.Name = "cbReceptionistSalary";
            this.cbReceptionistSalary.Size = new System.Drawing.Size(163, 23);
            this.cbReceptionistSalary.TabIndex = 9;
            // 
            // cbReceptionistDutyTime
            // 
            this.cbReceptionistDutyTime.FormattingEnabled = true;
            this.cbReceptionistDutyTime.Items.AddRange(new object[] {
            "9 am- 4 pm",
            "4 pm - 11 pm"});
            this.cbReceptionistDutyTime.Location = new System.Drawing.Point(12, 110);
            this.cbReceptionistDutyTime.Name = "cbReceptionistDutyTime";
            this.cbReceptionistDutyTime.Size = new System.Drawing.Size(180, 23);
            this.cbReceptionistDutyTime.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
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
            // txtReceptionistPhoneNumber
            // 
            this.txtReceptionistPhoneNumber.Location = new System.Drawing.Point(439, 58);
            this.txtReceptionistPhoneNumber.Name = "txtReceptionistPhoneNumber";
            this.txtReceptionistPhoneNumber.Size = new System.Drawing.Size(180, 23);
            this.txtReceptionistPhoneNumber.TabIndex = 21;
            // 
            // txtReceptionistFirstName
            // 
            this.txtReceptionistFirstName.Location = new System.Drawing.Point(222, 9);
            this.txtReceptionistFirstName.Name = "txtReceptionistFirstName";
            this.txtReceptionistFirstName.Size = new System.Drawing.Size(180, 23);
            this.txtReceptionistFirstName.TabIndex = 18;
            // 
            // txtReceptionistLastName
            // 
            this.txtReceptionistLastName.Location = new System.Drawing.Point(439, 9);
            this.txtReceptionistLastName.Name = "txtReceptionistLastName";
            this.txtReceptionistLastName.Size = new System.Drawing.Size(180, 23);
            this.txtReceptionistLastName.TabIndex = 19;
            // 
            // txtReceptionistEmail
            // 
            this.txtReceptionistEmail.Location = new System.Drawing.Point(222, 58);
            this.txtReceptionistEmail.Name = "txtReceptionistEmail";
            this.txtReceptionistEmail.Size = new System.Drawing.Size(180, 23);
            this.txtReceptionistEmail.TabIndex = 20;
            // 
            // txtReceptionistUserId
            // 
            this.txtReceptionistUserId.Location = new System.Drawing.Point(12, 9);
            this.txtReceptionistUserId.Name = "txtReceptionistUserId";
            this.txtReceptionistUserId.Size = new System.Drawing.Size(180, 23);
            this.txtReceptionistUserId.TabIndex = 22;
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
    }
}