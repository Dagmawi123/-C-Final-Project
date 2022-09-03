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
     partial class AdminPage : Form
    {

        // private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;

        public AdminPage()
        {
            InitializeComponent();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void navigationButtons1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
            lbl_dashboard.ForeColor = Color.Black;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;

            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;
            indicator.Location = new Point(168, 92);

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;



        }

        private void lbl_doctors_Click(object sender, EventArgs e)
        {
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.Black;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;
            indicator.Location = new Point(168, 134);
        }

        private void lbl_patients_Click(object sender, EventArgs e)
        {
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.Black;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;
            indicator.Location = new Point(168, 176);
        }

        private void lbl_receptionist_Click(object sender, EventArgs e)
        {

            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.Black;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;
            indicator.Location = new Point(168, 218);
        }

        private void lbl_nurse_Click(object sender, EventArgs e)
        {

            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.Black;
            lbl_department.ForeColor = Color.DarkGray;
            indicator.Location = new Point(168, 260);
        }

        private void lbl_department_Click(object sender, EventArgs e)
        {

            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.Black;
            indicator.Location = new Point(168, 302);
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuPanel1_Click_1(object sender, EventArgs e)
        {

        }

      
    } 
}
