namespace CProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_uname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.cb_utype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_see = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_uname
            // 
            this.lbl_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.Location = new System.Drawing.Point(232, 116);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(154, 29);
            this.lbl_uname.TabIndex = 0;
            this.lbl_uname.Text = "USER NAME";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PASSWORD";
            // 
            // tb_uname
            // 
            this.tb_uname.Location = new System.Drawing.Point(380, 122);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(166, 20);
            this.tb_uname.TabIndex = 2;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(380, 164);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '@';
            this.tb_pwd.Size = new System.Drawing.Size(166, 20);
            this.tb_pwd.TabIndex = 3;
            // 
            // cb_utype
            // 
            this.cb_utype.FormattingEnabled = true;
            this.cb_utype.Items.AddRange(new object[] {
            "ADMIN",
            "RECEPTIONIST",
            "DOCTOR"});
            this.cb_utype.Location = new System.Drawing.Point(253, 74);
            this.cb_utype.Name = "cb_utype";
            this.cb_utype.Size = new System.Drawing.Size(155, 21);
            this.cb_utype.TabIndex = 4;
            this.cb_utype.SelectedIndexChanged += new System.EventHandler(this.cb_utype_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 78);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome\r\n       TO\r\nHospital \r\n";
            // 
            // cb_see
            // 
            this.cb_see.AutoSize = true;
            this.cb_see.Location = new System.Drawing.Point(552, 167);
            this.cb_see.Name = "cb_see";
            this.cb_see.Size = new System.Drawing.Size(47, 17);
            this.cb_see.TabIndex = 8;
            this.cb_see.Text = "SEE";
            this.cb_see.UseVisualStyleBackColor = true;
            this.cb_see.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(565, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 268);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose your user type here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(599, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_see);
            this.Controls.Add(this.cb_utype);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_uname);
            this.Name = "Form1";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.ComboBox cb_utype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_see;
        private System.Windows.Forms.PictureBox pictureBox1;
       // private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

