
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
            this.panelManageReceptionistBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageReceptionistBottom
            // 
            this.panelManageReceptionistBottom.Controls.Add(this.btnViewReceptionist);
            this.panelManageReceptionistBottom.Controls.Add(this.btnAddNewRecptionist);
            this.panelManageReceptionistBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManageReceptionistBottom.Location = new System.Drawing.Point(0, 350);
            this.panelManageReceptionistBottom.Name = "panelManageReceptionistBottom";
            this.panelManageReceptionistBottom.Size = new System.Drawing.Size(800, 100);
            this.panelManageReceptionistBottom.TabIndex = 0;
            // 
            // btnViewReceptionist
            // 
            this.btnViewReceptionist.Location = new System.Drawing.Point(263, 27);
            this.btnViewReceptionist.Name = "btnViewReceptionist";
            this.btnViewReceptionist.Size = new System.Drawing.Size(137, 34);
            this.btnViewReceptionist.TabIndex = 1;
            this.btnViewReceptionist.Text = "View Receptionist";
            this.btnViewReceptionist.UseVisualStyleBackColor = true;
            this.btnViewReceptionist.Click += new System.EventHandler(this.btnViewReceptionist_Click);
            // 
            // btnAddNewRecptionist
            // 
            this.btnAddNewRecptionist.Location = new System.Drawing.Point(80, 27);
            this.btnAddNewRecptionist.Name = "btnAddNewRecptionist";
            this.btnAddNewRecptionist.Size = new System.Drawing.Size(144, 34);
            this.btnAddNewRecptionist.TabIndex = 0;
            this.btnAddNewRecptionist.Text = "Add New Receptionist";
            this.btnAddNewRecptionist.UseVisualStyleBackColor = true;
            this.btnAddNewRecptionist.Click += new System.EventHandler(this.btnAddNewRecptionist_Click);
            // 
            // panelManageReceptionistMain
            // 
            this.panelManageReceptionistMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageReceptionistMain.Location = new System.Drawing.Point(0, 0);
            this.panelManageReceptionistMain.Name = "panelManageReceptionistMain";
            this.panelManageReceptionistMain.Size = new System.Drawing.Size(800, 350);
            this.panelManageReceptionistMain.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageReceptionistBottom;
        private System.Windows.Forms.Button btnViewReceptionist;
        private System.Windows.Forms.Button btnAddNewRecptionist;
        private System.Windows.Forms.Panel panelManageReceptionistMain;
    }
}