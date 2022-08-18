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
        public DoctorHomePage()
        {
            InitializeComponent();
        }
        public DoctorHomePage(String name)
        {
            InitializeComponent();
            lbl_doc.Text = name;
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
    }
}
