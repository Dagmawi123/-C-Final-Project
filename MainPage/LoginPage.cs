using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProject.LoginPage
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(cmb_user.SelectedItem.ToString() == "Admin")
            {

                new MainPage.AdminPage().Show();
                this.Hide();   


            }
            if (cmb_user.SelectedItem.ToString() == "Doctor")
            {
                new MainPage.DoctorPage().Show();
                this.Hide();
            }
            if (cmb_user.SelectedItem.ToString() == "Receptionist")
            {
                new MainPage.ReceptionistPage().Show();
                this.Hide();
            }
        }
    }
}
