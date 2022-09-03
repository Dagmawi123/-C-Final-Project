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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorHomePage));
            this.lbl_doc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ind = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_trt = new System.Windows.Forms.Button();
            this.btn_chk = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_doc
            // 
            this.lbl_doc.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doc.Location = new System.Drawing.Point(656, 0);
            this.lbl_doc.Name = "lbl_doc";
            this.lbl_doc.Size = new System.Drawing.Size(76, 25);
            this.lbl_doc.TabIndex = 27;
            this.lbl_doc.Text = "Doctor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.lbl_ind);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_trt);
            this.panel1.Controls.Add(this.btn_chk);
            this.panel1.Controls.Add(this.btn_write);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 400);
            this.panel1.TabIndex = 32;
            // 
            // lbl_ind
            // 
            this.lbl_ind.AutoSize = true;
            this.lbl_ind.BackColor = System.Drawing.Color.Red;
            this.lbl_ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ind.Location = new System.Drawing.Point(12, 78);
            this.lbl_ind.Name = "lbl_ind";
            this.lbl_ind.Size = new System.Drawing.Size(19, 13);
            this.lbl_ind.TabIndex = 5;
            this.lbl_ind.Text = ">>";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-3, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Acivate/Deactivate Staus\r\n";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(48, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Page";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_trt
            // 
            this.btn_trt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_trt.Location = new System.Drawing.Point(29, 260);
            this.btn_trt.Name = "btn_trt";
            this.btn_trt.Size = new System.Drawing.Size(113, 43);
            this.btn_trt.TabIndex = 3;
            this.btn_trt.Text = "Treatement History";
            this.btn_trt.UseVisualStyleBackColor = false;
            this.btn_trt.Click += new System.EventHandler(this.btn_trt_Click);
            // 
            // btn_chk
            // 
            this.btn_chk.BackColor = System.Drawing.Color.White;
            this.btn_chk.Location = new System.Drawing.Point(24, 129);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(118, 47);
            this.btn_chk.TabIndex = 1;
            this.btn_chk.Text = "Check Appointments";
            this.btn_chk.UseVisualStyleBackColor = false;
            this.btn_chk.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_write.Location = new System.Drawing.Point(24, 196);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(118, 42);
            this.btn_write.TabIndex = 2;
            this.btn_write.Text = "Write Prescription";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 400);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_doc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(748, 439);
            this.MinimumSize = new System.Drawing.Size(621, 396);
            this.Name = "DoctorHomePage";
            this.Text = "Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorHomePage_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_doc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ind;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_trt;
        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }


}