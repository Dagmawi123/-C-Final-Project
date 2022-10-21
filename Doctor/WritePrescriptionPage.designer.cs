namespace CProject
{
    partial class WritePrescriptionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WritePrescriptionPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Pid = new System.Windows.Forms.TextBox();
            this.tb_dose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Btn_save = new Bunifu.UI.WinForms.BunifuImageButton();
            this.cb_Meds = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_Print = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicine Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medicine Dosage";
            // 
            // tb_Pid
            // 
            this.tb_Pid.Location = new System.Drawing.Point(329, 162);
            this.tb_Pid.Name = "tb_Pid";
            this.tb_Pid.Size = new System.Drawing.Size(100, 20);
            this.tb_Pid.TabIndex = 6;
            // 
            // tb_dose
            // 
            this.tb_dose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dose.Location = new System.Drawing.Point(329, 275);
            this.tb_dose.Multiline = true;
            this.tb_dose.Name = "tb_dose";
            this.tb_dose.Size = new System.Drawing.Size(198, 42);
            this.tb_dose.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prescription Page";
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
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Btn_save
            // 
            this.Btn_save.ActiveImage = null;
            this.Btn_save.AllowAnimations = true;
            this.Btn_save.AllowBuffering = false;
            this.Btn_save.AllowToggling = false;
            this.Btn_save.AllowZooming = true;
            this.Btn_save.AllowZoomingOnFocus = false;
            this.Btn_save.BackColor = System.Drawing.Color.Transparent;
            this.Btn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_save.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Btn_save.ErrorImage")));
            this.Btn_save.FadeWhenInactive = false;
            this.Btn_save.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Btn_save.Image = ((System.Drawing.Image)(resources.GetObject("Btn_save.Image")));
            this.Btn_save.ImageActive = null;
            this.Btn_save.ImageLocation = null;
            this.Btn_save.ImageMargin = 20;
            this.Btn_save.ImageSize = new System.Drawing.Size(57, 37);
            this.Btn_save.ImageZoomSize = new System.Drawing.Size(77, 57);
            this.Btn_save.InitialImage = ((System.Drawing.Image)(resources.GetObject("Btn_save.InitialImage")));
            this.Btn_save.Location = new System.Drawing.Point(513, 325);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Rotation = 0;
            this.Btn_save.ShowActiveImage = true;
            this.Btn_save.ShowCursorChanges = true;
            this.Btn_save.ShowImageBorders = false;
            this.Btn_save.ShowSizeMarkers = false;
            this.Btn_save.Size = new System.Drawing.Size(77, 57);
            this.Btn_save.TabIndex = 14;
            this.Btn_save.ToolTipText = "";
            this.Btn_save.WaitOnLoad = false;
            this.Btn_save.Zoom = 20;
            this.Btn_save.ZoomSpeed = 10;
            this.Btn_save.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // cb_Meds
            // 
            this.cb_Meds.BackColor = System.Drawing.Color.Transparent;
            this.cb_Meds.BackgroundColor = System.Drawing.Color.White;
            this.cb_Meds.BorderColor = System.Drawing.Color.Silver;
            this.cb_Meds.BorderRadius = 1;
            this.cb_Meds.Color = System.Drawing.Color.Silver;
            this.cb_Meds.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cb_Meds.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_Meds.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_Meds.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_Meds.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cb_Meds.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cb_Meds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Meds.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cb_Meds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Meds.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_Meds.FillDropDown = true;
            this.cb_Meds.FillIndicator = false;
            this.cb_Meds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Meds.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_Meds.ForeColor = System.Drawing.Color.Black;
            this.cb_Meds.FormattingEnabled = true;
            this.cb_Meds.Icon = null;
            this.cb_Meds.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_Meds.IndicatorColor = System.Drawing.Color.Gray;
            this.cb_Meds.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_Meds.ItemBackColor = System.Drawing.Color.White;
            this.cb_Meds.ItemBorderColor = System.Drawing.Color.White;
            this.cb_Meds.ItemForeColor = System.Drawing.Color.Black;
            this.cb_Meds.ItemHeight = 26;
            this.cb_Meds.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cb_Meds.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cb_Meds.ItemTopMargin = 3;
            this.cb_Meds.Location = new System.Drawing.Point(329, 217);
            this.cb_Meds.Name = "cb_Meds";
            this.cb_Meds.Size = new System.Drawing.Size(183, 32);
            this.cb_Meds.TabIndex = 15;
            this.cb_Meds.Text = null;
            this.cb_Meds.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_Meds.TextLeftMargin = 5;
            // 
            // btn_Print
            // 
            this.btn_Print.ActiveImage = null;
            this.btn_Print.AllowAnimations = true;
            this.btn_Print.AllowBuffering = false;
            this.btn_Print.AllowToggling = false;
            this.btn_Print.AllowZooming = true;
            this.btn_Print.AllowZoomingOnFocus = false;
            this.btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Print.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.ErrorImage")));
            this.btn_Print.FadeWhenInactive = false;
            this.btn_Print.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageActive = null;
            this.btn_Print.ImageLocation = null;
            this.btn_Print.ImageMargin = 10;
            this.btn_Print.ImageSize = new System.Drawing.Size(47, 35);
            this.btn_Print.ImageZoomSize = new System.Drawing.Size(57, 45);
            this.btn_Print.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.InitialImage")));
            this.btn_Print.Location = new System.Drawing.Point(533, 0);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Rotation = 0;
            this.btn_Print.ShowActiveImage = true;
            this.btn_Print.ShowCursorChanges = true;
            this.btn_Print.ShowImageBorders = false;
            this.btn_Print.ShowSizeMarkers = false;
            this.btn_Print.Size = new System.Drawing.Size(57, 45);
            this.btn_Print.TabIndex = 16;
            this.btn_Print.ToolTipText = "Click here to Print";
            this.btn_Print.WaitOnLoad = false;
            this.btn_Print.Zoom = 10;
            this.btn_Print.ZoomSpeed = 10;
            this.btn_Print.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // WritePrescriptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 394);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.cb_Meds);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dose);
            this.Controls.Add(this.tb_Pid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WritePrescriptionPage";
            this.Text = "WritePrescriptionPage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WritePrescriptionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Pid;
        private System.Windows.Forms.TextBox tb_dose;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Bunifu.UI.WinForms.BunifuImageButton Btn_save;
        private Bunifu.UI.WinForms.BunifuDropdown cb_Meds;
        private Bunifu.UI.WinForms.BunifuImageButton btn_Print;
    }
}