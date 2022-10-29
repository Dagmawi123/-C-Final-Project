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
using System.Configuration;

namespace CProject
{
    public partial class Check_Appointment : Form
    {
        public String ConString = ConfigurationManager.ConnectionStrings["HMSConnectionString"].ConnectionString;
        public String treat,Symptom;
        public String name1;
        public string paName;
        public int pId;
        public Check_Appointment()
        {
            InitializeComponent();
            TopLevel = false;
        }
        public Check_Appointment(String name)
        {
            InitializeComponent();
            TopLevel = false;
            name1 = name;
        }

        private void Check_Appointment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //    MessageBox.Show(e.RowIndex.ToString());
            try
            {
                if (dgv_PT[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    paName = dgv_PT[e.ColumnIndex, e.RowIndex].Value.ToString();
                    //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true;MultipleActiveResultSets=true";
                    SqlConnection s = new SqlConnection(ConString);
                    SqlCommand cmd = new SqlCommand("[spPatIdByName]", s);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = paName;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    s.Open();
                    cmd.ExecuteScalar();
                    pId = int.Parse(cmd.Parameters["@id"].Value.ToString());
                    //MessageBox.Show(pId.ToString());
                    // s.Open();
                    cmd.Dispose();

                    SqlCommand cmd2 = new SqlCommand("[spTrtById]", s);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@Id", pId);
                    cmd2.Parameters.Add("@trt", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd2.ExecuteReader();
                    treat = cmd2.Parameters["@trt"].Value.ToString();//unable to cast string to string[]

                    cmd2.Dispose();
                    SqlCommand cmd3 = new SqlCommand("[spSymById]", s);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@Id", pId);
                    cmd3.Parameters.Add("@sym", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd3.ExecuteReader();
                    Symptom = cmd3.Parameters["@sym"].Value.ToString();
                    if (!String.IsNullOrEmpty(Symptom) && !String.IsNullOrEmpty(treat))
                    {
                        
                        TreatPage tp = new TreatPage(pId);
                        tp.patientInfo1.Symptom = Symptom;
                        tp.patientInfo1.Treat = treat;
                        tp.Show();
                    }
                    else MessageBox.Show("First time!No History");
                }
            }
            catch (Exception eq) { MessageBox.Show("SERVERERROR!! Unable to load your specified patient history!"); }



        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            SqlDataReader sd;
            try
            {
                //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
                SqlConnection s = new SqlConnection(ConString);
                s.Open();
                SqlCommand cmd = new SqlCommand("[sploadAppointment]", s);
                cmd.CommandType = CommandType.StoredProcedure;
                //   SqlParameter spar = new SqlParameter();
                cmd.Parameters.AddWithValue("@uname", SqlDbType.VarChar).Value = name1;

                //spar.Direction = ParameterDirection.Input;
                //spar.Value = name1;
                sd = cmd.ExecuteReader();
                int r = 0;
                dgv_PT.DataSource = null;
                dgv_PT.Rows.Clear();
                if (!sd.HasRows) {
                    MessageBox.Show("You have no assigned appointments");
                    return;
                }
                while (sd.Read())
                {
                    dgv_PT.Rows.Add(1);
                    dgv_PT[0, r].Value = sd["Patient"].ToString();
                    dgv_PT[1, r].Value = sd["roomNo"].ToString();
                    dgv_PT[2, r].Value = sd["DateOf"].ToString();
                    r++;
                }
                s.Close();
                sd.Close();
            }
            catch (SqlException es)
            { //MessageBox.Show("You have no Appointments DOC!");
                MessageBox.Show("SERVERERROR!!Sorry cannot Load your Appointment(s)");
            }
        }

        private void dataGridView1_RowDividerHeightChanged(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
