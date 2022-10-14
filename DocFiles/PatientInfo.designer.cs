namespace CProject
{
    partial class PatientInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_sym = new System.Windows.Forms.Label();
            this.tb_sym = new System.Windows.Forms.TextBox();
            this.lbl_trt = new System.Windows.Forms.Label();
            this.tb_trt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sym
            // 
            this.lbl_sym.Location = new System.Drawing.Point(-3, 34);
            this.lbl_sym.Name = "lbl_sym";
            this.lbl_sym.Size = new System.Drawing.Size(105, 35);
            this.lbl_sym.TabIndex = 0;
            this.lbl_sym.Text = "Previous Symptoms";
            this.lbl_sym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sym
            // 
            this.tb_sym.Location = new System.Drawing.Point(0, 72);
            this.tb_sym.Multiline = true;
            this.tb_sym.Name = "tb_sym";
            this.tb_sym.ReadOnly = true;
            this.tb_sym.Size = new System.Drawing.Size(286, 134);
            this.tb_sym.TabIndex = 1;
            // 
            // lbl_trt
            // 
            this.lbl_trt.Location = new System.Drawing.Point(-3, 209);
            this.lbl_trt.Name = "lbl_trt";
            this.lbl_trt.Size = new System.Drawing.Size(105, 35);
            this.lbl_trt.TabIndex = 2;
            this.lbl_trt.Text = "Given Treatment";
            this.lbl_trt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_trt
            // 
            this.tb_trt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_trt.Location = new System.Drawing.Point(0, 237);
            this.tb_trt.Multiline = true;
            this.tb_trt.Name = "tb_trt";
            this.tb_trt.ReadOnly = true;
            this.tb_trt.Size = new System.Drawing.Size(286, 134);
            this.tb_trt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient History";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_trt);
            this.Controls.Add(this.lbl_trt);
            this.Controls.Add(this.tb_sym);
            this.Controls.Add(this.lbl_sym);
            this.Name = "PatientInfo";
            this.Size = new System.Drawing.Size(286, 371);
            this.Load += new System.EventHandler(this.PatientInfo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientInfo_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sym;
        private System.Windows.Forms.TextBox tb_sym;
        private System.Windows.Forms.Label lbl_trt;
        private System.Windows.Forms.TextBox tb_trt;
        private System.Windows.Forms.Label label2;
    }
}
