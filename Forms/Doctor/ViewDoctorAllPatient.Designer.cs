
namespace Hospital_Management_System.Client.Forms.Doctor
{
    partial class ViewDoctorAllPatient
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
            this.dgvAllPrient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPrient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllPrient
            // 
            this.dgvAllPrient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllPrient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPrient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllPrient.Location = new System.Drawing.Point(0, 0);
            this.dgvAllPrient.Name = "dgvAllPrient";
            this.dgvAllPrient.RowTemplate.Height = 25;
            this.dgvAllPrient.Size = new System.Drawing.Size(800, 450);
            this.dgvAllPrient.TabIndex = 0;
            // 
            // ViewDoctorAllPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllPrient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDoctorAllPatient";
            this.Text = "ViewDoctorAllPatient";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPrient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPrient;
    }
}