
namespace Hospital_Management_System.Client.Forms.Doctor
{
    partial class PatientPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientPrescription));
            this.panelPatientPrescriptionView = new System.Windows.Forms.Panel();
            this.dgvViewPrescription = new System.Windows.Forms.DataGridView();
            this.panelPatientPrescriptionData = new System.Windows.Forms.Panel();
            this.panelPatientPrescriptionDetails = new System.Windows.Forms.Panel();
            this.rtvPrescription = new System.Windows.Forms.RichTextBox();
            this.panelPatientPrescriptionLeft = new System.Windows.Forms.Panel();
            this.rtvInvestigation = new System.Windows.Forms.RichTextBox();
            this.panelPatientPrescriptionBottom = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPatientPrescriptionView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPrescription)).BeginInit();
            this.panelPatientPrescriptionData.SuspendLayout();
            this.panelPatientPrescriptionDetails.SuspendLayout();
            this.panelPatientPrescriptionLeft.SuspendLayout();
            this.panelPatientPrescriptionBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPatientPrescriptionView
            // 
            this.panelPatientPrescriptionView.Controls.Add(this.dgvViewPrescription);
            this.panelPatientPrescriptionView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPatientPrescriptionView.Location = new System.Drawing.Point(0, 0);
            this.panelPatientPrescriptionView.Margin = new System.Windows.Forms.Padding(4);
            this.panelPatientPrescriptionView.Name = "panelPatientPrescriptionView";
            this.panelPatientPrescriptionView.Size = new System.Drawing.Size(1006, 199);
            this.panelPatientPrescriptionView.TabIndex = 0;
            // 
            // dgvViewPrescription
            // 
            this.dgvViewPrescription.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvViewPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewPrescription.Location = new System.Drawing.Point(69, 13);
            this.dgvViewPrescription.Margin = new System.Windows.Forms.Padding(4);
            this.dgvViewPrescription.Name = "dgvViewPrescription";
            this.dgvViewPrescription.RowTemplate.Height = 25;
            this.dgvViewPrescription.Size = new System.Drawing.Size(879, 162);
            this.dgvViewPrescription.TabIndex = 0;
            this.dgvViewPrescription.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewPrescription_CellMouseDoubleClick);
            // 
            // panelPatientPrescriptionData
            // 
            this.panelPatientPrescriptionData.Controls.Add(this.panelPatientPrescriptionDetails);
            this.panelPatientPrescriptionData.Controls.Add(this.panelPatientPrescriptionLeft);
            this.panelPatientPrescriptionData.Controls.Add(this.panelPatientPrescriptionBottom);
            this.panelPatientPrescriptionData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatientPrescriptionData.Location = new System.Drawing.Point(0, 199);
            this.panelPatientPrescriptionData.Margin = new System.Windows.Forms.Padding(4);
            this.panelPatientPrescriptionData.Name = "panelPatientPrescriptionData";
            this.panelPatientPrescriptionData.Size = new System.Drawing.Size(1006, 357);
            this.panelPatientPrescriptionData.TabIndex = 1;
            // 
            // panelPatientPrescriptionDetails
            // 
            this.panelPatientPrescriptionDetails.Controls.Add(this.rtvPrescription);
            this.panelPatientPrescriptionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatientPrescriptionDetails.Location = new System.Drawing.Point(286, 0);
            this.panelPatientPrescriptionDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelPatientPrescriptionDetails.Name = "panelPatientPrescriptionDetails";
            this.panelPatientPrescriptionDetails.Size = new System.Drawing.Size(720, 291);
            this.panelPatientPrescriptionDetails.TabIndex = 2;
            // 
            // rtvPrescription
            // 
            this.rtvPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtvPrescription.Location = new System.Drawing.Point(0, 0);
            this.rtvPrescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtvPrescription.Name = "rtvPrescription";
            this.rtvPrescription.Size = new System.Drawing.Size(720, 291);
            this.rtvPrescription.TabIndex = 0;
            this.rtvPrescription.Text = "";
            // 
            // panelPatientPrescriptionLeft
            // 
            this.panelPatientPrescriptionLeft.Controls.Add(this.rtvInvestigation);
            this.panelPatientPrescriptionLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPatientPrescriptionLeft.Location = new System.Drawing.Point(0, 0);
            this.panelPatientPrescriptionLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelPatientPrescriptionLeft.Name = "panelPatientPrescriptionLeft";
            this.panelPatientPrescriptionLeft.Size = new System.Drawing.Size(286, 291);
            this.panelPatientPrescriptionLeft.TabIndex = 1;
            // 
            // rtvInvestigation
            // 
            this.rtvInvestigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtvInvestigation.Location = new System.Drawing.Point(0, 0);
            this.rtvInvestigation.Margin = new System.Windows.Forms.Padding(4);
            this.rtvInvestigation.Name = "rtvInvestigation";
            this.rtvInvestigation.Size = new System.Drawing.Size(286, 291);
            this.rtvInvestigation.TabIndex = 0;
            this.rtvInvestigation.Text = "";
            // 
            // panelPatientPrescriptionBottom
            // 
            this.panelPatientPrescriptionBottom.Controls.Add(this.btnPrint);
            this.panelPatientPrescriptionBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPatientPrescriptionBottom.Location = new System.Drawing.Point(0, 291);
            this.panelPatientPrescriptionBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelPatientPrescriptionBottom.Name = "panelPatientPrescriptionBottom";
            this.panelPatientPrescriptionBottom.Size = new System.Drawing.Size(1006, 66);
            this.panelPatientPrescriptionBottom.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(808, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 30);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PatientPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 556);
            this.Controls.Add(this.panelPatientPrescriptionData);
            this.Controls.Add(this.panelPatientPrescriptionView);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PatientPrescription";
            this.Text = "PatientPrescription";
            this.panelPatientPrescriptionView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPrescription)).EndInit();
            this.panelPatientPrescriptionData.ResumeLayout(false);
            this.panelPatientPrescriptionDetails.ResumeLayout(false);
            this.panelPatientPrescriptionLeft.ResumeLayout(false);
            this.panelPatientPrescriptionBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPatientPrescriptionView;
        private System.Windows.Forms.DataGridView dgvViewPrescription;
        private System.Windows.Forms.Panel panelPatientPrescriptionData;
        private System.Windows.Forms.Panel panelPatientPrescriptionDetails;
        private System.Windows.Forms.RichTextBox rtvPrescription;
        private System.Windows.Forms.Panel panelPatientPrescriptionLeft;
        private System.Windows.Forms.RichTextBox rtvInvestigation;
        private System.Windows.Forms.Panel panelPatientPrescriptionBottom;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}