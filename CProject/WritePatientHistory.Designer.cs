namespace CProject
{
    partial class WritePatientHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WritePatientHistory));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_apNo = new System.Windows.Forms.TextBox();
            this.lbl_ApNo = new System.Windows.Forms.Label();
            this.lbl_pId = new System.Windows.Forms.Label();
            this.lbl_sym = new System.Windows.Forms.Label();
            this.lbl_trt = new System.Windows.Forms.Label();
            this.tb_sym = new System.Windows.Forms.TextBox();
            this.tb_trt = new System.Windows.Forms.TextBox();
            this.tb_pNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_patients = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.66599F));
            this.tableLayoutPanel1.Controls.Add(this.tb_apNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ApNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sym, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_trt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_sym, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_trt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_pNo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57983F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42017F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 277);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_apNo
            // 
            this.tb_apNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_apNo.Location = new System.Drawing.Point(140, 23);
            this.tb_apNo.Name = "tb_apNo";
            this.tb_apNo.Size = new System.Drawing.Size(100, 20);
            this.tb_apNo.TabIndex = 2;
            // 
            // lbl_ApNo
            // 
            this.lbl_ApNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ApNo.AutoSize = true;
            this.lbl_ApNo.Location = new System.Drawing.Point(27, 26);
            this.lbl_ApNo.Name = "lbl_ApNo";
            this.lbl_ApNo.Size = new System.Drawing.Size(83, 13);
            this.lbl_ApNo.TabIndex = 0;
            this.lbl_ApNo.Text = "Appointment No";
            // 
            // lbl_pId
            // 
            this.lbl_pId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pId.AutoSize = true;
            this.lbl_pId.Location = new System.Drawing.Point(29, 93);
            this.lbl_pId.Name = "lbl_pId";
            this.lbl_pId.Size = new System.Drawing.Size(79, 13);
            this.lbl_pId.TabIndex = 1;
            this.lbl_pId.Text = "Prescription No";
            // 
            // lbl_sym
            // 
            this.lbl_sym.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sym.AutoSize = true;
            this.lbl_sym.Location = new System.Drawing.Point(41, 147);
            this.lbl_sym.Name = "lbl_sym";
            this.lbl_sym.Size = new System.Drawing.Size(55, 13);
            this.lbl_sym.TabIndex = 2;
            this.lbl_sym.Text = "Symptoms";
            this.lbl_sym.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_trt
            // 
            this.lbl_trt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_trt.AutoSize = true;
            this.lbl_trt.Location = new System.Drawing.Point(25, 219);
            this.lbl_trt.Name = "lbl_trt";
            this.lbl_trt.Size = new System.Drawing.Size(86, 13);
            this.lbl_trt.TabIndex = 3;
            this.lbl_trt.Text = "Treatment Given";
            // 
            // tb_sym
            // 
            this.tb_sym.Location = new System.Drawing.Point(140, 136);
            this.tb_sym.Multiline = true;
            this.tb_sym.Name = "tb_sym";
            this.tb_sym.Size = new System.Drawing.Size(474, 35);
            this.tb_sym.TabIndex = 5;
            // 
            // tb_trt
            // 
            this.tb_trt.Location = new System.Drawing.Point(140, 177);
            this.tb_trt.Multiline = true;
            this.tb_trt.Name = "tb_trt";
            this.tb_trt.Size = new System.Drawing.Size(474, 97);
            this.tb_trt.TabIndex = 6;
            // 
            // tb_pNo
            // 
            this.tb_pNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_pNo.Location = new System.Drawing.Point(140, 89);
            this.tb_pNo.Name = "tb_pNo";
            this.tb_pNo.Size = new System.Drawing.Size(100, 20);
            this.tb_pNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(552, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "Write your treatment summary here";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Save History";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(463, 347);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton1.TabIndex = 2;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Choose Patient Here-";
            // 
            // cb_patients
            // 
            this.cb_patients.FormattingEnabled = true;
            this.cb_patients.Location = new System.Drawing.Point(224, 37);
            this.cb_patients.Name = "cb_patients";
            this.cb_patients.Size = new System.Drawing.Size(171, 21);
            this.cb_patients.TabIndex = 4;
            // 
            // WritePatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 388);
            this.Controls.Add(this.cb_patients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WritePatientHistory";
            this.Text = "WritePatientHistory";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WritePatientHistory_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_apNo;
        private System.Windows.Forms.Label lbl_ApNo;
        private System.Windows.Forms.Label lbl_pId;
        private System.Windows.Forms.Label lbl_sym;
        private System.Windows.Forms.Label lbl_trt;
        private System.Windows.Forms.TextBox tb_sym;
        private System.Windows.Forms.TextBox tb_trt;
        private System.Windows.Forms.TextBox tb_pNo;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_patients;
    }
}