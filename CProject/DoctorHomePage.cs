using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProject
{
    public partial class DoctorHomePage : Form
    {
        public LoginPage lo = null;
        public String user;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorHomePage));

        public DoctorHomePage()
        {
            InitializeComponent();
        }
        public DoctorHomePage(String name)
        {
            InitializeComponent();
            //lbl_doc.Text = name;
            //lbl_wlcm.Text = "Welcome Dr." + name;
        }
        public DoctorHomePage(String name, LoginPage l)
        {
            InitializeComponent();
            //lbl_doc.Text = name;
            //l.Close();
            lo = l;
            //lbl_wlcm.Text = "Welcome Dr." + name;
            user = name;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_wlcome_Click(object sender, EventArgs e)
        {

        }

        private void newPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            //pictureBox1.Dispose();

            //WritePrescriptionPage w = new WritePrescriptionPage(lbl_doc.Text);
            ////this.ActivateMdiChild(w);
            //lbl_wlcm.Dispose();
            //w.MdiParent = this;
            //w.Dock = DockStyle.Fill;
            //w.Show();


        }

        //private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (this.ActiveMdiChild != null)
        //        this.ActiveMdiChild.Close();
        //    //pictureBox1.Dispose();

        //    //lbl_wlcm.Dispose();
        //    WritePatientHistory ww = new WritePatientHistory();
        //    ww.MdiParent = this;
        //    ww.Dock = DockStyle.Fill;
        //    ww.Show();
        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();

        }

        private void DoctorHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            lo.Close();
            panel2.Controls.Clear();
            //if (Check_Appointment.ActiveForm!=null)
            //    Check_Appointment.ActiveForm.Close();
            //if (WritePatientHistory.ActiveForm != null)
            //WritePatientHistory.ActiveForm.Close();
            //if(WritePatientHistory.ActiveForm!=null)
            //WritePrescriptionPage.ActiveForm.Close();
        }

        private void writeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            // pictureBox1.Dispose();
            //Check_Appointment c = new Check_Appointment(lbl_doc.Text);
            // c.MdiParent = this;
            //c.Dock = DockStyle.Fill;

            //lbl_wlcm.Dispose();
            //   c.Show();

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            this.lbl_ind.Location = new System.Drawing.Point(3, 162);
            pictureBox1.Dispose();
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Check_Appointment c = new Check_Appointment(user);
            // c.MdiParent = this;
            panel2.Controls.Add(c);
            c.Show();
            c.Size=panel2.Size ;

        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            this.lbl_ind.Location = new System.Drawing.Point(3, 243);
            WritePrescriptionPage wo = new WritePrescriptionPage(user);
            panel2.Controls.Clear();
            panel2.Controls.Add(wo);
            wo.Size = panel2.Size;
            wo.Show();

        }

        private void btn_trt_Click(object sender, EventArgs e)
        {
            this.lbl_ind.Location = new System.Drawing.Point(3, 333);
            WritePatientHistory wp = new WritePatientHistory();
            panel2.Controls.Clear();
            panel2.Controls.Add(wp);
            wp.Size = panel2.Size;
            wp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbl_ind.Location = new System.Drawing.Point(23, 78);
            panel2.Controls.Clear();
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Right)));
            // this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));

            //  this.pictureBox1.Image = global::CProject.Properties.Resources.doctor_stethescope;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            panel2.Controls.Add(this.pictureBox1);
        }

        private void btn_deact_Click(object sender, EventArgs e)
        {
            
            btn_deact.BackColor = Color.Red;
        }

        private void DoctorHomePage_Load(object sender, EventArgs e)
        {
            
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton1.Checked) { radioButton1.Text = "Make Me Inactive";
        //        radioButton1.BackColor = Color.Green;
        //    }
        //   else if (!radioButton1.Checked)
        //    {
        //        radioButton1.Text = "Make Me Active";
        //        radioButton1.BackColor = Color.Red;
        //    }
        //}
    }
}
