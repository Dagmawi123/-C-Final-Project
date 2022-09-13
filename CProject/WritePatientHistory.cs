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
    public partial class WritePatientHistory : Form
    {
        public int pId;
        public WritePatientHistory()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
            String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true;MultipleActiveResultSets=true";
            try
            {
                using (SqlConnection s = new SqlConnection(ConString))
                {
                    s.Open();
                  

                    // String query = "Insert into Prescription values(@ptID,@docId,@mid,@dose,@date)";
                    SqlCommand cmd = new SqlCommand("[spAddTreatment]", s);
                    SqlCommand cmd2 = new SqlCommand("[spIdSeparator]", s);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@name",SqlDbType.VarChar).Value=cb_patients.SelectedItem.ToString();
                    cmd2.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd2.ExecuteScalar();
                    pId = int.Parse(cmd2.Parameters["@id"].Value.ToString());

                    if (String.IsNullOrEmpty(tb_apNo.Text) && String.IsNullOrEmpty(tb_pNo.Text))
                    {
                        cmd.Parameters.AddWithValue("@prId", SqlDbType.VarChar).Value = DBNull.Value;
                        cmd.Parameters.AddWithValue("@aId", SqlDbType.VarChar).Value =DBNull.Value;
                    }
                    else if (String.IsNullOrEmpty(tb_apNo.Text))
                    {
                        cmd.Parameters.AddWithValue("@prId", SqlDbType.VarChar).Value = tb_pNo.Text;
                        cmd.Parameters.AddWithValue("@aId", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else if (String.IsNullOrEmpty(tb_pNo.Text))
                    {
                        cmd.Parameters.AddWithValue("@prId", SqlDbType.VarChar).Value = DBNull.Value;
                        cmd.Parameters.AddWithValue("@aId", SqlDbType.VarChar).Value = tb_apNo.Text;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@prId", SqlDbType.VarChar).Value = pId.ToString();
                        cmd.Parameters.AddWithValue("@aId", SqlDbType.VarChar).Value = tb_apNo.Text;
                    }


                    cmd.Parameters.AddWithValue("@ptId", SqlDbType.VarChar).Value = pId.ToString();
                    //cmd.Parameters.AddWithValue("@aId", SqlDbType.VarChar).Value = tb_apNo.Text;
                    //cmd.Parameters.AddWithValue("@prId", SqlDbType.VarChar).Value = tb_pNo.Text;
                    cmd.Parameters.AddWithValue("@sym", SqlDbType.VarChar).Value = tb_sym.Text;
                    cmd.Parameters.AddWithValue("@trt", SqlDbType.VarChar).Value = tb_trt.Text;

                    // cmd.ExecuteNonQuery();
                    int c = (int)cmd.ExecuteNonQuery();
                    MessageBox.Show(c.ToString() + " Number of rows inserted Successfully");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                //MessageBox.Show("Sorry!!Unable to save your prescription"); }
            }
        }
        private void WritePatientHistory_Load(object sender, EventArgs e)
        {
            String query = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";

            using (SqlConnection s = new SqlConnection(query)) {
                try { 
                SqlCommand cmd3 = new SqlCommand("[spLoadPatients]", s);
                SqlDataReader sr;
                cmd3.CommandType = CommandType.StoredProcedure;
                s.Open();
                sr = cmd3.ExecuteReader();
                //cb_patients.DataSource ;
                List<String> src = new List<string>();
                
                while (sr.Read()) { src.Add( sr.GetString(0));
                    }
                cb_patients.DataSource = src;
                    sr.Close();
            }
            catch (Exception e3) { MessageBox.Show(e3.Message); }
            }
        }
    }
}
