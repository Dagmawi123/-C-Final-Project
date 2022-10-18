namespace CProject.MainPage
{
    partial class DoctorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.top_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.navigationButtons1 = new CProject.NavigationButtons();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.side_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.indicator = new System.Windows.Forms.Panel();
            this.lbl_treatment = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_prescriptions = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_appointments = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_dashboard = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dea = new System.Windows.Forms.Label();
            this.btn_deact = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.top_panel.SuspendLayout();
            this.side_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
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
            // top_panel
            // 
            this.top_panel.BackgroundColor = System.Drawing.Color.White;
            this.top_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_panel.BackgroundImage")));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.BorderColor = System.Drawing.Color.Transparent;
            this.top_panel.BorderRadius = 30;
            this.top_panel.BorderThickness = 10;
            this.top_panel.Controls.Add(this.navigationButtons1);
            this.top_panel.Controls.Add(this.bunifuImageButton1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.ShowBorders = true;
            this.top_panel.Size = new System.Drawing.Size(788, 57);
            this.top_panel.TabIndex = 2;
            // 
            // navigationButtons1
            // 
            this.navigationButtons1.BackColor = System.Drawing.Color.Transparent;
            this.navigationButtons1.Location = new System.Drawing.Point(660, 18);
            this.navigationButtons1.Name = "navigationButtons1";
            this.navigationButtons1.Size = new System.Drawing.Size(107, 27);
            this.navigationButtons1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 10;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(55, 37);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(65, 47);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(65, 47);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_2);
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
            this.side_panel.Controls.Add(this.lbl_treatment);
            this.side_panel.Controls.Add(this.lbl_prescriptions);
            this.side_panel.Controls.Add(this.lbl_appointments);
            this.side_panel.Controls.Add(this.lbl_dashboard);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 57);
            this.side_panel.Name = "side_panel";
            this.side_panel.ShowBorders = true;
            this.side_panel.Size = new System.Drawing.Size(196, 441);
            this.side_panel.TabIndex = 3;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.SteelBlue;
            this.indicator.Location = new System.Drawing.Point(159, 185);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(3, 36);
            this.indicator.TabIndex = 4;
            // 
            // lbl_treatment
            // 
            this.lbl_treatment.AllowParentOverrides = false;
            this.lbl_treatment.AutoEllipsis = false;
            this.lbl_treatment.AutoSize = false;
            this.lbl_treatment.CursorType = null;
            this.lbl_treatment.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_treatment.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_treatment.Location = new System.Drawing.Point(10, 311);
            this.lbl_treatment.Name = "lbl_treatment";
            this.lbl_treatment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_treatment.Size = new System.Drawing.Size(180, 36);
            this.lbl_treatment.TabIndex = 5;
            this.lbl_treatment.Text = "Treatment History";
            this.lbl_treatment.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_treatment.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_treatment.Click += new System.EventHandler(this.lbl_treatment_Click);
            // 
            // lbl_prescriptions
            // 
            this.lbl_prescriptions.AllowParentOverrides = false;
            this.lbl_prescriptions.AutoEllipsis = false;
            this.lbl_prescriptions.AutoSize = false;
            this.lbl_prescriptions.CursorType = null;
            this.lbl_prescriptions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_prescriptions.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_prescriptions.Location = new System.Drawing.Point(10, 269);
            this.lbl_prescriptions.Name = "lbl_prescriptions";
            this.lbl_prescriptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_prescriptions.Size = new System.Drawing.Size(180, 36);
            this.lbl_prescriptions.TabIndex = 2;
            this.lbl_prescriptions.Text = "Prescriptions";
            this.lbl_prescriptions.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_prescriptions.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_prescriptions.Click += new System.EventHandler(this.lbl_prescription_Click);
            // 
            // lbl_appointments
            // 
            this.lbl_appointments.AllowParentOverrides = false;
            this.lbl_appointments.AutoEllipsis = false;
            this.lbl_appointments.AutoSize = false;
            this.lbl_appointments.CursorType = null;
            this.lbl_appointments.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_appointments.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_appointments.Location = new System.Drawing.Point(12, 227);
            this.lbl_appointments.Name = "lbl_appointments";
            this.lbl_appointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_appointments.Size = new System.Drawing.Size(180, 36);
            this.lbl_appointments.TabIndex = 1;
            this.lbl_appointments.Text = "Appointments";
            this.lbl_appointments.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_appointments.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_appointments.Click += new System.EventHandler(this.lbl_appointments_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AllowParentOverrides = false;
            this.lbl_dashboard.AutoEllipsis = false;
            this.lbl_dashboard.AutoSize = false;
            this.lbl_dashboard.CursorType = null;
            this.lbl_dashboard.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_dashboard.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_dashboard.Location = new System.Drawing.Point(10, 185);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_dashboard.Size = new System.Drawing.Size(180, 36);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dashboard";
            this.lbl_dashboard.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dashboard.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_dashboard.Click += new System.EventHandler(this.lbl_dashboard_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 5;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(55, 28);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(60, 33);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(532, 408);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = false;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(60, 33);
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.ToolTipText = "LogOut Here";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 5;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(196, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 438);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.lbl_dea);
            this.panel1.Controls.Add(this.btn_deact);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 438);
            this.panel1.TabIndex = 0;
            // 
            // lbl_dea
            // 
            this.lbl_dea.AutoSize = true;
            this.lbl_dea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dea.ForeColor = System.Drawing.Color.Red;
            this.lbl_dea.Location = new System.Drawing.Point(3, 418);
            this.lbl_dea.Name = "lbl_dea";
            this.lbl_dea.Size = new System.Drawing.Size(238, 20);
            this.lbl_dea.TabIndex = 2;
            this.lbl_dea.Text = "You are not active in the system.";
            // 
            // btn_deact
            // 
            this.btn_deact.AllowBindingControlLocation = false;
            this.btn_deact.BackColor = System.Drawing.Color.Transparent;
            this.btn_deact.BindingControl = this.pictureBox1;
            this.btn_deact.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.btn_deact.BorderThickness = 1;
            this.btn_deact.Checked = true;
            this.btn_deact.ForeColor = System.Drawing.Color.Lime;
            this.btn_deact.Location = new System.Drawing.Point(0, 326);
            this.btn_deact.Name = "btn_deact";
            this.btn_deact.OutlineColor = System.Drawing.Color.Gray;
            this.btn_deact.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_deact.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.btn_deact.RadioColor = System.Drawing.Color.Red;
            this.btn_deact.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_deact.Size = new System.Drawing.Size(34, 34);
            this.btn_deact.TabIndex = 1;
            this.btn_deact.Text = null;
            this.btn_deact.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.bunifuRadioButton1_CheckedChanged2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 0;
            this.bunifuElipse2.TargetControl = this;
            // 
            // DoctorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(788, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "DoctorPage";
            this.Text = "AdminPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoctorPage_KeyDown);
            this.top_panel.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuPanel side_panel;
        private Bunifu.UI.WinForms.BunifuPanel top_panel;
        private System.Windows.Forms.Panel indicator;
        private Bunifu.UI.WinForms.BunifuLabel lbl_prescriptions;
        private Bunifu.UI.WinForms.BunifuLabel lbl_appointments;
        private Bunifu.UI.WinForms.BunifuLabel lbl_dashboard;
        private Bunifu.UI.WinForms.BunifuLabel lbl_treatment;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuRadioButton btn_deact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_dea;
        private NavigationButtons navigationButtons1;
        //  private NavigationButtons navigationButtons2;
    }
}