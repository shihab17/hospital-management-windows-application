
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class ViewPatient
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
            this.panelViewPatient = new System.Windows.Forms.Panel();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.panelBottomViewPatient = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.btnPatientDelete = new System.Windows.Forms.Button();
            this.btnPatientUpdate = new System.Windows.Forms.Button();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientDate = new System.Windows.Forms.TextBox();
            this.panelViewPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.panelBottomViewPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewPatient
            // 
            this.panelViewPatient.Controls.Add(this.dgvPatient);
            this.panelViewPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewPatient.Location = new System.Drawing.Point(0, 0);
            this.panelViewPatient.Name = "panelViewPatient";
            this.panelViewPatient.Size = new System.Drawing.Size(800, 213);
            this.panelViewPatient.TabIndex = 0;
            // 
            // dgvPatient
            // 
            this.dgvPatient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(12, 35);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.RowTemplate.Height = 25;
            this.dgvPatient.Size = new System.Drawing.Size(745, 150);
            this.dgvPatient.TabIndex = 0;
            this.dgvPatient.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatient_CellMouseDoubleClick);
            // 
            // panelBottomViewPatient
            // 
            this.panelBottomViewPatient.Controls.Add(this.groupBox1);
            this.panelBottomViewPatient.Controls.Add(this.txtPatientId);
            this.panelBottomViewPatient.Controls.Add(this.btnPatientDelete);
            this.panelBottomViewPatient.Controls.Add(this.btnPatientUpdate);
            this.panelBottomViewPatient.Controls.Add(this.cbDoctorName);
            this.panelBottomViewPatient.Controls.Add(this.txtPatientAge);
            this.panelBottomViewPatient.Controls.Add(this.txtPatientName);
            this.panelBottomViewPatient.Controls.Add(this.txtPatientDate);
            this.panelBottomViewPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomViewPatient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelBottomViewPatient.Location = new System.Drawing.Point(0, 213);
            this.panelBottomViewPatient.Name = "panelBottomViewPatient";
            this.panelBottomViewPatient.Size = new System.Drawing.Size(800, 238);
            this.panelBottomViewPatient.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(378, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 42);
            this.groupBox1.TabIndex = 26;
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
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(12, 6);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(100, 29);
            this.txtPatientId.TabIndex = 6;
            // 
            // btnPatientDelete
            // 
            this.btnPatientDelete.Location = new System.Drawing.Point(206, 148);
            this.btnPatientDelete.Name = "btnPatientDelete";
            this.btnPatientDelete.Size = new System.Drawing.Size(95, 37);
            this.btnPatientDelete.TabIndex = 5;
            this.btnPatientDelete.Text = "Delete";
            this.btnPatientDelete.UseVisualStyleBackColor = true;
            this.btnPatientDelete.Click += new System.EventHandler(this.btnPatientDelete_Click);
            // 
            // btnPatientUpdate
            // 
            this.btnPatientUpdate.Location = new System.Drawing.Point(73, 148);
            this.btnPatientUpdate.Name = "btnPatientUpdate";
            this.btnPatientUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnPatientUpdate.TabIndex = 4;
            this.btnPatientUpdate.Text = "Update";
            this.btnPatientUpdate.UseVisualStyleBackColor = true;
            this.btnPatientUpdate.Click += new System.EventHandler(this.btnPatientUpdate_Click);
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.Location = new System.Drawing.Point(206, 91);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(142, 29);
            this.cbDoctorName.TabIndex = 3;
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(12, 91);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(156, 29);
            this.txtPatientAge.TabIndex = 2;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(206, 37);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(156, 29);
            this.txtPatientName.TabIndex = 1;
            // 
            // txtPatientDate
            // 
            this.txtPatientDate.Location = new System.Drawing.Point(12, 37);
            this.txtPatientDate.Name = "txtPatientDate";
            this.txtPatientDate.Size = new System.Drawing.Size(156, 29);
            this.txtPatientDate.TabIndex = 0;
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBottomViewPatient);
            this.Controls.Add(this.panelViewPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPatient";
            this.Text = "ViewPatient";
            this.panelViewPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.panelBottomViewPatient.ResumeLayout(false);
            this.panelBottomViewPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelViewPatient;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Panel panelBottomViewPatient;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientDate;
        private System.Windows.Forms.Button btnPatientDelete;
        private System.Windows.Forms.Button btnPatientUpdate;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
    }
}