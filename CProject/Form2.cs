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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.BackColor = Color.Red;
            label1.Text = "HOSPITAL";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label3.BackColor = Color.Green;
            label3.Text = "SYSTEM";

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label4.BackColor = Color.Pink;
 //           label3.Text = "SYSTEM";

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            label2.BackColor = Color.Yellow;
            label2.Text = "MANAGEMENT";
            this.Hide();
            LoginPage l = new LoginPage(this);
            l.Show();
        }
    }
}
