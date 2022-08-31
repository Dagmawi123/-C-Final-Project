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
        public LoginPage lo=null;
        public DoctorHomePage()
        {
            InitializeComponent();
        }
        public DoctorHomePage(String name)
        {
            InitializeComponent();
            lbl_doc.Text = name;
            lbl_wlcm.Text = "Welcome Dr." + name;
        }
        public DoctorHomePage(String name,LoginPage l) {
            InitializeComponent();
            lbl_doc.Text = name;
            //l.Close();
            lo = l;
            lbl_wlcm.Text = "Welcome Dr." + name;


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
            pictureBox1.Dispose();

            WritePrescriptionPage w = new WritePrescriptionPage(lbl_doc.Text);
            //this.ActivateMdiChild(w);
            lbl_wlcm.Dispose();
            w.MdiParent = this;
            w.Dock = DockStyle.Fill;
            w.Show();


        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            pictureBox1.Dispose();

            lbl_wlcm.Dispose();
            WritePatientHistory ww = new WritePatientHistory();
            ww.MdiParent = this;
            ww.Dock = DockStyle.Fill;
            ww.Show();
        }

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
        }

        private void writeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild!=null)
            this.ActiveMdiChild.Close();
            pictureBox1.Dispose();
            Check_Appointment c = new Check_Appointment(lbl_doc.Text);
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;

            lbl_wlcm.Dispose();
            c.Show();

        }
    }
}
