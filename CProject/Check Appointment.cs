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

namespace CProject
{
    public partial class Check_Appointment : Form
    {
        public String name1;
        public Check_Appointment()
        {
            InitializeComponent();
        }
        public Check_Appointment(String name)
        {
            InitializeComponent();
            name1 = name;
        }

        private void Check_Appointment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { SqlDataReader sd;
            try
            {
                String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
                SqlConnection s = new SqlConnection(ConString);
                s.Open();
                SqlCommand cmd = new SqlCommand("Select Patient,roomNo,DateOf from Doctor_appointment where username=" + name1, s);
                sd = cmd.ExecuteReader();
                int r = 0;
                while (sd.Read())
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1[0, r].Value = sd["Patient"].ToString();
                    dataGridView1[1, r].Value = sd["roomNo"].ToString();
                    dataGridView1[2, r].Value = sd["DateOf"].ToString();
                    r++;
                }
            }
            catch (SqlException es) { MessageBox.Show("You have no Appointments DOC!"); }
            }
    }
}
