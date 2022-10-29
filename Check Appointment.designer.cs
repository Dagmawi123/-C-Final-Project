namespace CProject
{
    partial class Check_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Appointment));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgv_PT = new System.Windows.Forms.DataGridView();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomAppointedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Load = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PT
            // 
            this.dgv_PT.AllowUserToAddRows = false;
            this.dgv_PT.AllowUserToDeleteRows = false;
            this.dgv_PT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgv_PT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PT.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_PT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientName,
            this.DateOfAppointment,
            this.RoomAppointedAt});
            this.dgv_PT.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_PT.Location = new System.Drawing.Point(-2, 108);
            this.dgv_PT.Name = "dgv_PT";
            this.dgv_PT.ReadOnly = true;
            this.dgv_PT.Size = new System.Drawing.Size(592, 173);
            this.dgv_PT.TabIndex = 1;
            this.dgv_PT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dgv_PT.RowDividerHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowDividerHeightChanged);
            this.dgv_PT.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // DateOfAppointment
            // 
            this.DateOfAppointment.HeaderText = "RoomAppoinedAt";
            this.DateOfAppointment.Name = "DateOfAppointment";
            this.DateOfAppointment.ReadOnly = true;
            // 
            // RoomAppointedAt
            // 
            this.RoomAppointedAt.HeaderText = "Date Of Appointment";
            this.RoomAppointedAt.Name = "RoomAppointedAt";
            this.RoomAppointedAt.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check Your Appointments here";
            // 
            // btn_Load
            // 
            this.btn_Load.AllowAnimations = true;
            this.btn_Load.AllowMouseEffects = true;
            this.btn_Load.AllowToggling = false;
            this.btn_Load.AnimationSpeed = 200;
            this.btn_Load.AutoGenerateColors = false;
            this.btn_Load.AutoRoundBorders = false;
            this.btn_Load.AutoSizeLeftIcon = true;
            this.btn_Load.AutoSizeRightIcon = true;
            this.btn_Load.BackColor = System.Drawing.Color.Transparent;
            this.btn_Load.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Load.BackgroundImage")));
            this.btn_Load.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Load.ButtonText = "Load Appointments Assigned for me";
            this.btn_Load.ButtonTextMarginLeft = 0;
            this.btn_Load.ColorContrastOnClick = 45;
            this.btn_Load.ColorContrastOnHover = 45;
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Load.CustomizableEdges = borderEdges1;
            this.btn_Load.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Load.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Load.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Load.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Load.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Load.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Load.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Load.IconMarginLeft = 11;
            this.btn_Load.IconPadding = 10;
            this.btn_Load.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Load.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Load.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Load.IconSize = 25;
            this.btn_Load.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Load.IdleBorderRadius = 1;
            this.btn_Load.IdleBorderThickness = 1;
            this.btn_Load.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Load.IdleIconLeftImage = null;
            this.btn_Load.IdleIconRightImage = null;
            this.btn_Load.IndicateFocus = false;
            this.btn_Load.Location = new System.Drawing.Point(-2, 80);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Load.OnDisabledState.BorderRadius = 1;
            this.btn_Load.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Load.OnDisabledState.BorderThickness = 1;
            this.btn_Load.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Load.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Load.OnDisabledState.IconLeftImage = null;
            this.btn_Load.OnDisabledState.IconRightImage = null;
            this.btn_Load.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Load.onHoverState.BorderRadius = 1;
            this.btn_Load.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Load.onHoverState.BorderThickness = 1;
            this.btn_Load.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Load.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Load.onHoverState.IconLeftImage = null;
            this.btn_Load.onHoverState.IconRightImage = null;
            this.btn_Load.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Load.OnIdleState.BorderRadius = 1;
            this.btn_Load.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Load.OnIdleState.BorderThickness = 1;
            this.btn_Load.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Load.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Load.OnIdleState.IconLeftImage = null;
            this.btn_Load.OnIdleState.IconRightImage = null;
            this.btn_Load.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Load.OnPressedState.BorderRadius = 1;
            this.btn_Load.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Load.OnPressedState.BorderThickness = 1;
            this.btn_Load.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Load.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Load.OnPressedState.IconLeftImage = null;
            this.btn_Load.OnPressedState.IconRightImage = null;
            this.btn_Load.Size = new System.Drawing.Size(256, 22);
            this.btn_Load.TabIndex = 3;
            this.btn_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Load.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Load.TextMarginLeft = 0;
            this.btn_Load.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Load.UseDefaultRadiusAndThickness = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(12, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 39);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Check_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 389);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_PT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check_Appointment";
            this.Text = "Check_Appointment";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Check_Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_PT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomAppointedAt;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Load;
        private System.Windows.Forms.TextBox textBox1;
    }
}