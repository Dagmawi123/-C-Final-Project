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
            this.label6 = new System.Windows.Forms.Label();
            this.cb_patients = new System.Windows.Forms.ComboBox();
            this.btn_save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_apNo
            // 
            this.tb_apNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_apNo.AutoCompleteCustomSource.AddRange(new string[] {
            "Null"});
            this.tb_apNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_apNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_apNo.Location = new System.Drawing.Point(135, 33);
            this.tb_apNo.Name = "tb_apNo";
            this.tb_apNo.Size = new System.Drawing.Size(100, 20);
            this.tb_apNo.TabIndex = 2;
            this.tb_apNo.TextChanged += new System.EventHandler(this.tb_apNo_TextChanged);
            // 
            // lbl_ApNo
            // 
            this.lbl_ApNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ApNo.AutoSize = true;
            this.lbl_ApNo.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApNo.Location = new System.Drawing.Point(5, 36);
            this.lbl_ApNo.Name = "lbl_ApNo";
            this.lbl_ApNo.Size = new System.Drawing.Size(122, 15);
            this.lbl_ApNo.TabIndex = 0;
            this.lbl_ApNo.Text = "Appointment No";
            // 
            // lbl_pId
            // 
            this.lbl_pId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pId.AutoSize = true;
            this.lbl_pId.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pId.Location = new System.Drawing.Point(8, 123);
            this.lbl_pId.Name = "lbl_pId";
            this.lbl_pId.Size = new System.Drawing.Size(116, 15);
            this.lbl_pId.TabIndex = 1;
            this.lbl_pId.Text = "Prescription No";
            // 
            // lbl_sym
            // 
            this.lbl_sym.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sym.AutoSize = true;
            this.lbl_sym.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sym.Location = new System.Drawing.Point(27, 199);
            this.lbl_sym.Name = "lbl_sym";
            this.lbl_sym.Size = new System.Drawing.Size(78, 15);
            this.lbl_sym.TabIndex = 2;
            this.lbl_sym.Text = "Symptoms";
            this.lbl_sym.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_trt
            // 
            this.lbl_trt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_trt.AutoSize = true;
            this.lbl_trt.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trt.Location = new System.Drawing.Point(5, 282);
            this.lbl_trt.Name = "lbl_trt";
            this.lbl_trt.Size = new System.Drawing.Size(121, 15);
            this.lbl_trt.TabIndex = 3;
            this.lbl_trt.Text = "Treatment Given";
            // 
            // tb_sym
            // 
            this.tb_sym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sym.Location = new System.Drawing.Point(135, 178);
            this.tb_sym.Multiline = true;
            this.tb_sym.Name = "tb_sym";
            this.tb_sym.Size = new System.Drawing.Size(457, 35);
            this.tb_sym.TabIndex = 5;
            // 
            // tb_trt
            // 
            this.tb_trt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_trt.Location = new System.Drawing.Point(135, 241);
            this.tb_trt.Multiline = true;
            this.tb_trt.Name = "tb_trt";
            this.tb_trt.Size = new System.Drawing.Size(457, 97);
            this.tb_trt.TabIndex = 6;
            // 
            // tb_pNo
            // 
            this.tb_pNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_pNo.AutoCompleteCustomSource.AddRange(new string[] {
            "Null"});
            this.tb_pNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_pNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_pNo.Location = new System.Drawing.Point(135, 121);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Choose Patient Here->";
            // 
            // cb_patients
            // 
            this.cb_patients.FormattingEnabled = true;
            this.cb_patients.Location = new System.Drawing.Point(224, 37);
            this.cb_patients.Name = "cb_patients";
            this.cb_patients.Size = new System.Drawing.Size(171, 21);
            this.cb_patients.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.AllowAnimations = true;
            this.btn_save.AllowMouseEffects = true;
            this.btn_save.AllowToggling = false;
            this.btn_save.AnimationSpeed = 200;
            this.btn_save.AutoGenerateColors = false;
            this.btn_save.AutoRoundBorders = false;
            this.btn_save.AutoSizeLeftIcon = true;
            this.btn_save.AutoSizeRightIcon = true;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BackColor1 = System.Drawing.Color.CadetBlue;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save.ButtonText = "Save Summary";
            this.btn_save.ButtonTextMarginLeft = 0;
            this.btn_save.ColorContrastOnClick = 45;
            this.btn_save.ColorContrastOnHover = 45;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_save.CustomizableEdges = borderEdges2;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_save.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_save.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_save.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_save.IconMarginLeft = 11;
            this.btn_save.IconPadding = 10;
            this.btn_save.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_save.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_save.IconSize = 25;
            this.btn_save.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.IdleBorderRadius = 1;
            this.btn_save.IdleBorderThickness = 1;
            this.btn_save.IdleFillColor = System.Drawing.Color.CadetBlue;
            this.btn_save.IdleIconLeftImage = null;
            this.btn_save.IdleIconRightImage = null;
            this.btn_save.IndicateFocus = false;
            this.btn_save.Location = new System.Drawing.Point(457, 408);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_save.OnDisabledState.BorderRadius = 1;
            this.btn_save.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save.OnDisabledState.BorderThickness = 1;
            this.btn_save.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_save.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_save.OnDisabledState.IconLeftImage = null;
            this.btn_save.OnDisabledState.IconRightImage = null;
            this.btn_save.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_save.onHoverState.BorderRadius = 1;
            this.btn_save.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save.onHoverState.BorderThickness = 1;
            this.btn_save.onHoverState.FillColor = System.Drawing.Color.Cyan;
            this.btn_save.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_save.onHoverState.IconLeftImage = null;
            this.btn_save.onHoverState.IconRightImage = null;
            this.btn_save.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.OnIdleState.BorderRadius = 1;
            this.btn_save.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save.OnIdleState.BorderThickness = 1;
            this.btn_save.OnIdleState.FillColor = System.Drawing.Color.CadetBlue;
            this.btn_save.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_save.OnIdleState.IconLeftImage = null;
            this.btn_save.OnIdleState.IconRightImage = null;
            this.btn_save.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_save.OnPressedState.BorderRadius = 1;
            this.btn_save.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save.OnPressedState.BorderThickness = 1;
            this.btn_save.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_save.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_save.OnPressedState.IconLeftImage = null;
            this.btn_save.OnPressedState.IconRightImage = null;
            this.btn_save.Size = new System.Drawing.Size(134, 29);
            this.btn_save.TabIndex = 6;
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_save.TextMarginLeft = 0;
            this.btn_save.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_save.UseDefaultRadiusAndThickness = true;
            this.btn_save.Click += new System.EventHandler(this.btnSave_click);
            // 
            // WritePatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(591, 438);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_patients);
            this.Controls.Add(this.label6);
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
        //private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_patients;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_save;
    }
}