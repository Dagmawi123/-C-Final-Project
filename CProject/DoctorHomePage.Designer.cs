namespace CProject
{
    partial class DoctorHomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_doc = new System.Windows.Forms.Label();
            this.lbl_wlcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.prescriptionToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeAppointmentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fileToolStripMenuItem.Text = "Appointment";
            // 
            // writeAppointmentToolStripMenuItem
            // 
            this.writeAppointmentToolStripMenuItem.Name = "writeAppointmentToolStripMenuItem";
            this.writeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.writeAppointmentToolStripMenuItem.Text = "Check Appointment";
            this.writeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.writeAppointmentToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPrescriptionToolStripMenuItem});
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // newPrescriptionToolStripMenuItem
            // 
            this.newPrescriptionToolStripMenuItem.Name = "newPrescriptionToolStripMenuItem";
            this.newPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newPrescriptionToolStripMenuItem.Text = "New Prescription";
            this.newPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.newPrescriptionToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeStatusToolStripMenuItem,
            this.addPatientToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changeStatusToolStripMenuItem
            // 
            this.changeStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inactiveToolStripMenuItem,
            this.activeToolStripMenuItem});
            this.changeStatusToolStripMenuItem.Name = "changeStatusToolStripMenuItem";
            this.changeStatusToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.changeStatusToolStripMenuItem.Text = "Change Status";
            // 
            // inactiveToolStripMenuItem
            // 
            this.inactiveToolStripMenuItem.Name = "inactiveToolStripMenuItem";
            this.inactiveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inactiveToolStripMenuItem.Text = "Inactive";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.activeToolStripMenuItem.Text = "Active";
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.addPatientToolStripMenuItem.Text = "Write Patient Treatment History";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // lbl_doc
            // 
            this.lbl_doc.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doc.Location = new System.Drawing.Point(522, 24);
            this.lbl_doc.Name = "lbl_doc";
            this.lbl_doc.Size = new System.Drawing.Size(76, 25);
            this.lbl_doc.TabIndex = 27;
            this.lbl_doc.Text = "Doctor";
            // 
            // lbl_wlcome
            // 
            this.lbl_wlcome.BackColor = System.Drawing.Color.Yellow;
            this.lbl_wlcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_wlcome.Font = new System.Drawing.Font("YESHUAH", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wlcome.Location = new System.Drawing.Point(0, 24);
            this.lbl_wlcome.Name = "lbl_wlcome";
            this.lbl_wlcome.Size = new System.Drawing.Size(598, 229);
            this.lbl_wlcome.TabIndex = 22;
            this.lbl_wlcome.Text = "Welcome Doctor";
            this.lbl_wlcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_wlcome.Click += new System.EventHandler(this.lbl_wlcome_Click);
            // 
            // DoctorHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 253);
            this.Controls.Add(this.lbl_doc);
            this.Controls.Add(this.lbl_wlcome);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorHomePage";
            this.Text = "Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorHomePage_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem;
        private System.Windows.Forms.Label lbl_doc;
        private System.Windows.Forms.ToolStripMenuItem writeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_wlcome;
    }

  
    }
