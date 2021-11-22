
namespace Hospital_Management_System.Client.Forms.Admin
{
    partial class ManageReceptionist
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
            this.panelManageReceptionistBottom = new System.Windows.Forms.Panel();
            this.btnViewReceptionist = new System.Windows.Forms.Button();
            this.btnAddNewRecptionist = new System.Windows.Forms.Button();
            this.panelManageReceptionistMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelToatlReceptionist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelManageReceptionistBottom.SuspendLayout();
            this.panelManageReceptionistMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageReceptionistBottom
            // 
            this.panelManageReceptionistBottom.BackColor = System.Drawing.Color.Teal;
            this.panelManageReceptionistBottom.Controls.Add(this.btnViewReceptionist);
            this.panelManageReceptionistBottom.Controls.Add(this.btnAddNewRecptionist);
            this.panelManageReceptionistBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManageReceptionistBottom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelManageReceptionistBottom.Location = new System.Drawing.Point(0, 400);
            this.panelManageReceptionistBottom.Name = "panelManageReceptionistBottom";
            this.panelManageReceptionistBottom.Size = new System.Drawing.Size(800, 50);
            this.panelManageReceptionistBottom.TabIndex = 0;
            // 
            // btnViewReceptionist
            // 
            this.btnViewReceptionist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewReceptionist.Location = new System.Drawing.Point(260, 6);
            this.btnViewReceptionist.Name = "btnViewReceptionist";
            this.btnViewReceptionist.Size = new System.Drawing.Size(188, 34);
            this.btnViewReceptionist.TabIndex = 1;
            this.btnViewReceptionist.Text = "View Receptionist";
            this.btnViewReceptionist.UseVisualStyleBackColor = false;
            this.btnViewReceptionist.Click += new System.EventHandler(this.btnViewReceptionist_Click);
            // 
            // btnAddNewRecptionist
            // 
            this.btnAddNewRecptionist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNewRecptionist.Location = new System.Drawing.Point(42, 6);
            this.btnAddNewRecptionist.Name = "btnAddNewRecptionist";
            this.btnAddNewRecptionist.Size = new System.Drawing.Size(212, 34);
            this.btnAddNewRecptionist.TabIndex = 0;
            this.btnAddNewRecptionist.Text = "Add New Receptionist";
            this.btnAddNewRecptionist.UseVisualStyleBackColor = false;
            this.btnAddNewRecptionist.Click += new System.EventHandler(this.btnAddNewRecptionist_Click);
            // 
            // panelManageReceptionistMain
            // 
            this.panelManageReceptionistMain.Controls.Add(this.panel2);
            this.panelManageReceptionistMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageReceptionistMain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelManageReceptionistMain.Location = new System.Drawing.Point(0, 0);
            this.panelManageReceptionistMain.Name = "panelManageReceptionistMain";
            this.panelManageReceptionistMain.Size = new System.Drawing.Size(800, 400);
            this.panelManageReceptionistMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.labelToatlReceptionist);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(300, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 5;
            // 
            // labelToatlReceptionist
            // 
            this.labelToatlReceptionist.AutoSize = true;
            this.labelToatlReceptionist.Location = new System.Drawing.Point(89, 73);
            this.labelToatlReceptionist.Name = "labelToatlReceptionist";
            this.labelToatlReceptionist.Size = new System.Drawing.Size(31, 36);
            this.labelToatlReceptionist.TabIndex = 1;
            this.labelToatlReceptionist.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(192, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Receptionist";
            // 
            // ManageReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelManageReceptionistMain);
            this.Controls.Add(this.panelManageReceptionistBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageReceptionist";
            this.Text = "ManageReceptionist";
            this.Load += new System.EventHandler(this.ManageReceptionist_Load);
            this.panelManageReceptionistBottom.ResumeLayout(false);
            this.panelManageReceptionistMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageReceptionistBottom;
        private System.Windows.Forms.Button btnViewReceptionist;
        private System.Windows.Forms.Button btnAddNewRecptionist;
        private System.Windows.Forms.Panel panelManageReceptionistMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelToatlReceptionist;
        private System.Windows.Forms.Label label2;
    }
}