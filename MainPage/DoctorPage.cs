using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CProject.Database;

namespace CProject.MainPage
{
    public partial class DoctorPage : Form
    {
        public String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
        public int docId;
        public LoginPage lo = null;
        public String user;




        public DoctorPage()
        {
            InitializeComponent();

        }
        public DoctorPage(String name, LoginPage l)
        {
           InitializeComponent();
          lo = l;     
            user = name;

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }



        private void navigationButtons1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(panel1);
            panel1.Show();
            this.indicator.Location = new System.Drawing.Point(159, 185);
            lbl_dashboard.ForeColor = Color.Black;
            lbl_appointments.ForeColor = Color.DarkGray;
            lbl_prescriptions.ForeColor = Color.DarkGray;
            lbl_treatment.ForeColor = Color.DarkGray;


        }

        private void lbl_appointments_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            this.indicator.Location = new System.Drawing.Point(171, 227);
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_appointments.ForeColor = Color.Black;
            lbl_prescriptions.ForeColor = Color.DarkGray;
            lbl_treatment.ForeColor = Color.DarkGray;
            // indicator.Location = new Point(168, 134);
            Check_Appointment c = new Check_Appointment(user);
            // c.MdiParent = this
            panel2.Controls.Clear();
            panel2.Controls.Add(c);
            c.Show();
            c.Size = panel2.Size;

        }

        private void lbl_prescription_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            this.indicator.Location = new System.Drawing.Point(171, 269);
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_appointments.ForeColor = Color.DarkGray;
            lbl_prescriptions.ForeColor = Color.Black;
            lbl_treatment.ForeColor = Color.DarkGray;

            // indicator.Location = new Point(168, 176);
            WritePrescriptionPage wo = new WritePrescriptionPage(user);
            panel2.Controls.Clear();
            panel2.Controls.Add(wo);
            wo.Size = panel2.Size;
            wo.Show();

           

        }

        private void lbl_receptionist_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_appointments.ForeColor = Color.DarkGray;
            lbl_prescriptions.ForeColor = Color.DarkGray;

            lbl_treatment.ForeColor = Color.DarkGray;

            indicator.Location = new Point(168, 218);




            

        }

     
        private void lbl_treatment_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            this.indicator.Location = new System.Drawing.Point(178, 311);
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_appointments.ForeColor = Color.DarkGray;
            lbl_prescriptions.ForeColor = Color.DarkGray;
            lbl_treatment.ForeColor = Color.Black;

            //  indicator.Location = new Point(168, 302);
            WritePatientHistory wp = new WritePatientHistory();
            panel2.Controls.Clear();
            panel2.Controls.Add(wp);
            wp.Size = panel2.Size;
            wp.Show();






        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }




        private void btn_addDoctor_Click(object sender, EventArgs e)
        {



        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {
            HelpForm h = new HelpForm();
            h.TopMost = true;
            h.Show();
        }

        private void DoctorPage_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.ToString() == "F1")
            {
                bunifuImageButton1_Click_2(sender, new EventArgs());
            }


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            int Status;
            if (btn_deact.RadioColor == Color.Green)
            {
                btn_deact.RadioColor = Color.Red;
                lbl_dea.Text = "You are not currently on the system.Please press the button!";
                Status = 0;
            }
            else
            {
                btn_deact.RadioColor = Color.Green;
                // btn_deact.Text = "Deactivate Status";
                lbl_dea.Text = "";
                Status = 1;
            }
            using (SqlConnection s = new SqlConnection(ConString))
            {
                s.Open();
                SqlCommand cmd = new SqlCommand("[spChangeStatus]", s);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@docId", docId);
                cmd.Parameters.AddWithValue("@preValue", Status);
                cmd.ExecuteScalar();
                MessageBox.Show("Status Changed!");
            }
        }

        private void DoctorHomePage_Load(object sender, EventArgs e)
        {
          
            using (SqlConnection s = new SqlConnection(ConString))
            {
                s.Open();
                SqlCommand cmd2 = new SqlCommand("[spDocIdByName]", s);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@name", user);
                cmd2.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                // cmd2.Parameters["@id"].Direction = ParameterDirection.Output;
                cmd2.ExecuteScalar();
                docId = int.Parse(cmd2.Parameters["@id"].Value.ToString());

            }
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
          var res=  MessageBox.Show("Are you sure that you want to logout?", "Warning",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                this.Hide();
                lo.Show();
            }
        }
    }
}
