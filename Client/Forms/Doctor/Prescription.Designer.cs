
namespace Hospital_Management_System.Client.Forms.Doctor
{
    partial class Prescription
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
            this.panelPrescriptionTop = new System.Windows.Forms.Panel();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.cbTestName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAfter = new System.Windows.Forms.RadioButton();
            this.rbBefore = new System.Windows.Forms.RadioButton();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDosages = new System.Windows.Forms.TextBox();
            this.txtMedecineName = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatientId = new System.Windows.Forms.Label();
            this.panelPrescription = new System.Windows.Forms.Panel();
            this.panelPrescriptionMain = new System.Windows.Forms.Panel();
            this.rtbPrescription = new System.Windows.Forms.RichTextBox();
            this.panelPrescriptionLeft = new System.Windows.Forms.Panel();
            this.rtbPrescriptionTest = new System.Windows.Forms.RichTextBox();
            this.panelPrescriptionBottom = new System.Windows.Forms.Panel();
            this.btnSavePrescription = new System.Windows.Forms.Button();
            this.panelPrescriptionTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelPrescription.SuspendLayout();
            this.panelPrescriptionMain.SuspendLayout();
            this.panelPrescriptionLeft.SuspendLayout();
            this.panelPrescriptionBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrescriptionTop
            // 
            this.panelPrescriptionTop.Controls.Add(this.btnAddTest);
            this.panelPrescriptionTop.Controls.Add(this.cbTestName);
            this.panelPrescriptionTop.Controls.Add(this.label3);
            this.panelPrescriptionTop.Controls.Add(this.label2);
            this.panelPrescriptionTop.Controls.Add(this.label1);
            this.panelPrescriptionTop.Controls.Add(this.btnAddMedicine);
            this.panelPrescriptionTop.Controls.Add(this.groupBox1);
            this.panelPrescriptionTop.Controls.Add(this.txtDuration);
            this.panelPrescriptionTop.Controls.Add(this.txtDosages);
            this.panelPrescriptionTop.Controls.Add(this.txtMedecineName);
            this.panelPrescriptionTop.Controls.Add(this.labelGender);
            this.panelPrescriptionTop.Controls.Add(this.labelAge);
            this.panelPrescriptionTop.Controls.Add(this.labelPatientName);
            this.panelPrescriptionTop.Controls.Add(this.labelPatientId);
            this.panelPrescriptionTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrescriptionTop.Location = new System.Drawing.Point(0, 0);
            this.panelPrescriptionTop.Name = "panelPrescriptionTop";
            this.panelPrescriptionTop.Size = new System.Drawing.Size(820, 136);
            this.panelPrescriptionTop.TabIndex = 0;
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(127, 97);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(60, 23);
            this.btnAddTest.TabIndex = 13;
            this.btnAddTest.Text = "Add";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // cbTestName
            // 
            this.cbTestName.FormattingEnabled = true;
            this.cbTestName.Items.AddRange(new object[] {
            "X-Ray"});
            this.cbTestName.Location = new System.Drawing.Point(0, 95);
            this.cbTestName.Name = "cbTestName";
            this.cbTestName.Size = new System.Drawing.Size(121, 23);
            this.cbTestName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dosages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 76);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Drug Name";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(738, 95);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedicine.TabIndex = 8;
            this.btnAddMedicine.Text = "Add";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAfter);
            this.groupBox1.Controls.Add(this.rbBefore);
            this.groupBox1.Location = new System.Drawing.Point(532, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 32);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbAfter
            // 
            this.rbAfter.AutoSize = true;
            this.rbAfter.Location = new System.Drawing.Point(112, 11);
            this.rbAfter.Name = "rbAfter";
            this.rbAfter.Size = new System.Drawing.Size(81, 19);
            this.rbAfter.TabIndex = 1;
            this.rbAfter.TabStop = true;
            this.rbAfter.Text = "After Food";
            this.rbAfter.UseVisualStyleBackColor = true;
            // 
            // rbBefore
            // 
            this.rbBefore.AutoSize = true;
            this.rbBefore.Location = new System.Drawing.Point(6, 11);
            this.rbBefore.Name = "rbBefore";
            this.rbBefore.Size = new System.Drawing.Size(89, 19);
            this.rbBefore.TabIndex = 0;
            this.rbBefore.TabStop = true;
            this.rbBefore.Text = "Before Food";
            this.rbBefore.UseVisualStyleBackColor = true;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(471, 97);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(55, 23);
            this.txtDuration.TabIndex = 6;
            // 
            // txtDosages
            // 
            this.txtDosages.Location = new System.Drawing.Point(346, 97);
            this.txtDosages.Name = "txtDosages";
            this.txtDosages.Size = new System.Drawing.Size(119, 23);
            this.txtDosages.TabIndex = 5;
            // 
            // txtMedecineName
            // 
            this.txtMedecineName.Location = new System.Drawing.Point(193, 97);
            this.txtMedecineName.Name = "txtMedecineName";
            this.txtMedecineName.Size = new System.Drawing.Size(147, 23);
            this.txtMedecineName.TabIndex = 4;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(266, 13);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 15);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(185, 13);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(93, 13);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(39, 15);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "Name";
            // 
            // labelPatientId
            // 
            this.labelPatientId.AutoSize = true;
            this.labelPatientId.Location = new System.Drawing.Point(22, 13);
            this.labelPatientId.Name = "labelPatientId";
            this.labelPatientId.Size = new System.Drawing.Size(17, 15);
            this.labelPatientId.TabIndex = 0;
            this.labelPatientId.Text = "Id";
            // 
            // panelPrescription
            // 
            this.panelPrescription.Controls.Add(this.panelPrescriptionMain);
            this.panelPrescription.Controls.Add(this.panelPrescriptionLeft);
            this.panelPrescription.Controls.Add(this.panelPrescriptionBottom);
            this.panelPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrescription.Location = new System.Drawing.Point(0, 136);
            this.panelPrescription.Name = "panelPrescription";
            this.panelPrescription.Size = new System.Drawing.Size(820, 314);
            this.panelPrescription.TabIndex = 1;
            // 
            // panelPrescriptionMain
            // 
            this.panelPrescriptionMain.Controls.Add(this.rtbPrescription);
            this.panelPrescriptionMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrescriptionMain.Location = new System.Drawing.Point(193, 0);
            this.panelPrescriptionMain.Name = "panelPrescriptionMain";
            this.panelPrescriptionMain.Size = new System.Drawing.Size(627, 264);
            this.panelPrescriptionMain.TabIndex = 3;
            // 
            // rtbPrescription
            // 
            this.rtbPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPrescription.Location = new System.Drawing.Point(0, 0);
            this.rtbPrescription.Name = "rtbPrescription";
            this.rtbPrescription.Size = new System.Drawing.Size(627, 264);
            this.rtbPrescription.TabIndex = 0;
            this.rtbPrescription.Text = "Rx.";
            // 
            // panelPrescriptionLeft
            // 
            this.panelPrescriptionLeft.Controls.Add(this.rtbPrescriptionTest);
            this.panelPrescriptionLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrescriptionLeft.Location = new System.Drawing.Point(0, 0);
            this.panelPrescriptionLeft.Name = "panelPrescriptionLeft";
            this.panelPrescriptionLeft.Size = new System.Drawing.Size(193, 264);
            this.panelPrescriptionLeft.TabIndex = 2;
            // 
            // rtbPrescriptionTest
            // 
            this.rtbPrescriptionTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPrescriptionTest.Location = new System.Drawing.Point(0, 0);
            this.rtbPrescriptionTest.Name = "rtbPrescriptionTest";
            this.rtbPrescriptionTest.Size = new System.Drawing.Size(193, 264);
            this.rtbPrescriptionTest.TabIndex = 0;
            this.rtbPrescriptionTest.Text = "";
            // 
            // panelPrescriptionBottom
            // 
            this.panelPrescriptionBottom.Controls.Add(this.btnSavePrescription);
            this.panelPrescriptionBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrescriptionBottom.Location = new System.Drawing.Point(0, 264);
            this.panelPrescriptionBottom.Name = "panelPrescriptionBottom";
            this.panelPrescriptionBottom.Size = new System.Drawing.Size(820, 50);
            this.panelPrescriptionBottom.TabIndex = 1;
            // 
            // btnSavePrescription
            // 
            this.btnSavePrescription.Location = new System.Drawing.Point(695, 15);
            this.btnSavePrescription.Name = "btnSavePrescription";
            this.btnSavePrescription.Size = new System.Drawing.Size(75, 23);
            this.btnSavePrescription.TabIndex = 0;
            this.btnSavePrescription.Text = "Save";
            this.btnSavePrescription.UseVisualStyleBackColor = true;
            this.btnSavePrescription.Click += new System.EventHandler(this.btnSavePrescription_Click);
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.panelPrescription);
            this.Controls.Add(this.panelPrescriptionTop);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.panelPrescriptionTop.ResumeLayout(false);
            this.panelPrescriptionTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPrescription.ResumeLayout(false);
            this.panelPrescriptionMain.ResumeLayout(false);
            this.panelPrescriptionLeft.ResumeLayout(false);
            this.panelPrescriptionBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrescriptionTop;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.Label labelPatientId;
        private System.Windows.Forms.Panel panelPrescription;
        private System.Windows.Forms.RichTextBox rtbPrescription;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAfter;
        private System.Windows.Forms.RadioButton rbBefore;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDosages;
        private System.Windows.Forms.TextBox txtMedecineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.ComboBox cbTestName;
        private System.Windows.Forms.Panel panelPrescriptionMain;
        private System.Windows.Forms.Panel panelPrescriptionLeft;
        private System.Windows.Forms.RichTextBox rtbPrescriptionTest;
        private System.Windows.Forms.Panel panelPrescriptionBottom;
        private System.Windows.Forms.Button btnSavePrescription;
    }
}