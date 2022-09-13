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
    public partial class WritePrescriptionPage : Form
    {
        public int docId;
        public int medId;
        public String DocName;
        public WritePrescriptionPage(String name)
        {
            InitializeComponent();
            TopLevel = false;
            TopMost = true;
            DocName = name;
        }

        private void WritePrescriptionPage_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(e.ToString());
            String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
            try
            {
                using (SqlConnection s = new SqlConnection(ConString))
                {
                    s.Open();
                    // String query = "Insert into Prescription values(@ptID,@docId,@mid,@dose,@date)";
                    SqlCommand cmd = new SqlCommand("[spAddPrescription]", s);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlCommand cmd1 = new SqlCommand("[spMedIdByName]", s);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@medName", tb_mname.Text);
                    //cmd1.Parameters.Add("@id");
                    cmd1.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                //    cmd1.Parameters["@id"].Direction = ParameterDirection.Output;
                    cmd1.ExecuteScalar();
                    medId = int.Parse(cmd1.Parameters["@id"].Value.ToString());

                    //if (medId > 0) { MessageBox.Show("Medicine id retrieved"); }
                    SqlCommand cmd2 = new SqlCommand("[spDocIdByName]", s);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@name", DocName);
                    cmd2.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                   // cmd2.Parameters["@id"].Direction = ParameterDirection.Output;
                    cmd2.ExecuteScalar();
                    docId = int.Parse(cmd2.Parameters["@id"].Value.ToString());


                   // cmd2.ExecuteScalar();
                    // if (docId > 0) { MessageBox.Show("DoctorId retrieved"); }
                    cmd.Parameters.AddWithValue("@ptID", SqlDbType.VarChar).Value = tb_Pid.Text;
                    cmd.Parameters.AddWithValue("@docId", SqlDbType.VarChar).Value = docId;
                    cmd.Parameters.AddWithValue("@mid", SqlDbType.VarChar).Value = medId;
                    cmd.Parameters.AddWithValue("@dose", SqlDbType.VarChar).Value = tb_dose.Text;

                    // cmd.ExecuteNonQuery();
                    int c = (int)cmd.ExecuteNonQuery();
                    MessageBox.Show(c.ToString() + " Number of rows inserted Successfully");
                }
            }
            catch (Exception e2)
            { MessageBox.Show("Sorry!!Unable to save your prescription"); 
              //  MessageBox.Show(e2.Message);
            }
            }

        //public void bunifuButton1_MouseClick(object sender, MouseEventArgs e) {
        //    MessageBox.Show("Here for mouse click event");
        //}
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }

   
    }

