namespace CProject
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.top_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.navigationButtons1 = new CProject.NavigationButtons();
            this.side_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.indicator = new System.Windows.Forms.Panel();
            this.lbl_department = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_nurse = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_receptionist = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_patients = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_doctors = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_dashboard = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.top_panel.SuspendLayout();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            this.bunifuFormDock1.FormDragging += new System.EventHandler<Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs>(this.bunifuFormDock1_FormDragging);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // top_panel
            // 
            this.top_panel.BackgroundColor = System.Drawing.Color.White;
            this.top_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_panel.BackgroundImage")));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.BorderColor = System.Drawing.Color.Transparent;
            this.top_panel.BorderRadius = 30;
            this.top_panel.BorderThickness = 10;
            this.top_panel.Controls.Add(this.navigationButtons1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.ShowBorders = true;
            this.top_panel.Size = new System.Drawing.Size(800, 73);
            this.top_panel.TabIndex = 2;
            // 
            // navigationButtons1
            // 
            this.navigationButtons1.BackColor = System.Drawing.Color.Transparent;
            this.navigationButtons1.Location = new System.Drawing.Point(661, 24);
            this.navigationButtons1.Name = "navigationButtons1";
            this.navigationButtons1.Size = new System.Drawing.Size(111, 24);
            this.navigationButtons1.TabIndex = 0;
            // 
            // side_panel
            // 
            this.side_panel.BackgroundColor = System.Drawing.Color.White;
            this.side_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("side_panel.BackgroundImage")));
            this.side_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.side_panel.BorderColor = System.Drawing.Color.Transparent;
            this.side_panel.BorderRadius = 30;
            this.side_panel.BorderThickness = 10;
            this.side_panel.Controls.Add(this.indicator);
            this.side_panel.Controls.Add(this.lbl_department);
            this.side_panel.Controls.Add(this.lbl_nurse);
            this.side_panel.Controls.Add(this.lbl_receptionist);
            this.side_panel.Controls.Add(this.lbl_patients);
            this.side_panel.Controls.Add(this.lbl_doctors);
            this.side_panel.Controls.Add(this.lbl_dashboard);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 73);
            this.side_panel.Name = "side_panel";
            this.side_panel.ShowBorders = true;
            this.side_panel.Size = new System.Drawing.Size(196, 429);
            this.side_panel.TabIndex = 3;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.SteelBlue;
            this.indicator.Location = new System.Drawing.Point(168, 92);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(3, 36);
            this.indicator.TabIndex = 4;
            // 
            // lbl_department
            // 
            this.lbl_department.AllowParentOverrides = false;
            this.lbl_department.AutoEllipsis = false;
            this.lbl_department.AutoSize = false;
            this.lbl_department.CursorType = null;
            this.lbl_department.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_department.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_department.Location = new System.Drawing.Point(8, 302);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_department.Size = new System.Drawing.Size(180, 36);
            this.lbl_department.TabIndex = 5;
            this.lbl_department.Text = "Department";
            this.lbl_department.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_department.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_department.Click += new System.EventHandler(this.lbl_department_Click);
            // 
            // lbl_nurse
            // 
            this.lbl_nurse.AllowParentOverrides = false;
            this.lbl_nurse.AutoEllipsis = false;
            this.lbl_nurse.AutoSize = false;
            this.lbl_nurse.CursorType = null;
            this.lbl_nurse.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nurse.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_nurse.Location = new System.Drawing.Point(8, 260);
            this.lbl_nurse.Name = "lbl_nurse";
            this.lbl_nurse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_nurse.Size = new System.Drawing.Size(180, 36);
            this.lbl_nurse.TabIndex = 4;
            this.lbl_nurse.Text = "Nurse";
            this.lbl_nurse.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nurse.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_nurse.Click += new System.EventHandler(this.lbl_nurse_Click);
            // 
            // lbl_receptionist
            // 
            this.lbl_receptionist.AllowParentOverrides = false;
            this.lbl_receptionist.AutoEllipsis = false;
            this.lbl_receptionist.AutoSize = false;
            this.lbl_receptionist.CursorType = null;
            this.lbl_receptionist.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_receptionist.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_receptionist.Location = new System.Drawing.Point(8, 218);
            this.lbl_receptionist.Name = "lbl_receptionist";
            this.lbl_receptionist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_receptionist.Size = new System.Drawing.Size(180, 36);
            this.lbl_receptionist.TabIndex = 3;
            this.lbl_receptionist.Text = "Receptionist";
            this.lbl_receptionist.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_receptionist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_receptionist.Click += new System.EventHandler(this.lbl_receptionist_Click);
            // 
            // lbl_patients
            // 
            this.lbl_patients.AllowParentOverrides = false;
            this.lbl_patients.AutoEllipsis = false;
            this.lbl_patients.AutoSize = false;
            this.lbl_patients.CursorType = null;
            this.lbl_patients.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_patients.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_patients.Location = new System.Drawing.Point(8, 176);
            this.lbl_patients.Name = "lbl_patients";
            this.lbl_patients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_patients.Size = new System.Drawing.Size(180, 36);
            this.lbl_patients.TabIndex = 2;
            this.lbl_patients.Text = "Patients";
            this.lbl_patients.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_patients.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_patients.Click += new System.EventHandler(this.lbl_patients_Click);
            // 
            // lbl_doctors
            // 
            this.lbl_doctors.AllowParentOverrides = false;
            this.lbl_doctors.AutoEllipsis = false;
            this.lbl_doctors.AutoSize = false;
            this.lbl_doctors.CursorType = null;
            this.lbl_doctors.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_doctors.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_doctors.Location = new System.Drawing.Point(8, 134);
            this.lbl_doctors.Name = "lbl_doctors";
            this.lbl_doctors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_doctors.Size = new System.Drawing.Size(180, 36);
            this.lbl_doctors.TabIndex = 1;
            this.lbl_doctors.Text = "Doctors";
            this.lbl_doctors.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_doctors.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_doctors.Click += new System.EventHandler(this.lbl_doctors_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AllowParentOverrides = false;
            this.lbl_dashboard.AutoEllipsis = false;
            this.lbl_dashboard.AutoSize = false;
            this.lbl_dashboard.CursorType = null;
            this.lbl_dashboard.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_dashboard.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_dashboard.Location = new System.Drawing.Point(8, 92);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_dashboard.Size = new System.Drawing.Size(180, 36);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dashboard";
            this.lbl_dashboard.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dashboard.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_dashboard.Click += new System.EventHandler(this.lbl_dashboard_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 10;
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(800, 502);
            this.bunifuPanel1.TabIndex = 5;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click_1);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 30;
            this.bunifuPanel2.BorderThickness = 10;
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(800, 502);
            this.bunifuPanel2.TabIndex = 6;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.top_panel.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.UI.WinForms.BunifuPanel side_panel;
        private Bunifu.UI.WinForms.BunifuPanel top_panel;
        private System.Windows.Forms.Panel indicator;
        private Bunifu.UI.WinForms.BunifuLabel lbl_department;
        private Bunifu.UI.WinForms.BunifuLabel lbl_nurse;
        private Bunifu.UI.WinForms.BunifuLabel lbl_receptionist;
        private Bunifu.UI.WinForms.BunifuLabel lbl_patients;
        private Bunifu.UI.WinForms.BunifuLabel lbl_doctors;
        private Bunifu.UI.WinForms.BunifuLabel lbl_dashboard;
        private NavigationButtons navigationButtons1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
    }
}