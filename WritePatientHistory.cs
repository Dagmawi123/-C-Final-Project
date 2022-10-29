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
using System.Text.RegularExpressions;

namespace CProject
{
    public partial class WritePatientHistory : Form
    {
        public String ConString = ConfigurationManager.ConnectionStrings["HMSConnectionString"].ConnectionString;
        public int pId;
        public WritePatientHistory()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void WritePatientHistory_Load(object sender, EventArgs e)
        {
            //String query = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";

            using (SqlConnection s = new SqlConnection(ConString))
            {
                try
                {
                    SqlCommand cmd3 = new SqlCommand("[spLoadPatients]", s);
                    SqlDataReader sr;
                    cmd3.CommandType = CommandType.StoredProcedure;
                    s.Open();
                    sr = cmd3.ExecuteReader();
                    //cb_patients.DataSource ;
                    List<String> src = new List<string>();

                    while (sr.Read())
                    {
                        src.Add(sr.GetString(0));
                    }
                    cb_patients.DataSource = src;
                    sr.Close();
                }
                catch (Exception e3) { MessageBox.Show("ServerError! Sorry unable to load the Patients! "
                    +e3.Message); }
            }


        }

        private void btnSave_click(object sender, EventArgs e)
        {


            //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true;MultipleActiveResultSets=true";
            String pat = @"([0-9]{4})$";
            String pat2 = "(^\\d{4}$)";
            Regex re = new Regex(pat2);
            if (!re.IsMatch(tb_apNo.Text))
            {
                MessageBox.Show("Appointment Number must be 4 digit integers!!");
                return;
            }
            if (!re.IsMatch(tb_pNo.Text))
            {
                MessageBox.Show("Prescription number must be 4 digit integers!!");
                return;
            }
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
                    cmd2.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = cb_patients.SelectedItem.ToString();
                    cmd2.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd2.ExecuteScalar();
                    pId = int.Parse(cmd2.Parameters["@id"].Value.ToString());

                    if (String.IsNullOrEmpty(tb_apNo.Text) && String.IsNullOrEmpty(tb_pNo.Text) || tb_apNo.Text == "Null" && tb_pNo.Text == "Null" || String.IsNullOrEmpty(tb_apNo.Text) && tb_pNo.Text == "Null" || String.IsNullOrEmpty(tb_pNo.Text) && tb_apNo.Text == "Null")
                    {
                        cmd.Parameters.AddWithValue("@prId", SqlDbType.VarChar).Value = DBNull.Value;
                        cmd.Parameters.AddWithValue("@aId", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else if (String.IsNullOrEmpty(tb_apNo.Text) || tb_apNo.Text == "Null")
                    {
                        cmd.Parameters.AddWithValue("@prId", SqlDbType.VarChar).Value = tb_pNo.Text;
                        cmd.Parameters.AddWithValue("@aId", SqlDbType.VarChar).Value = DBNull.Value;
                    }
                    else if (String.IsNullOrEmpty(tb_pNo.Text) || tb_pNo.Text == "Null")
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
                    if (c > 0)
                        MessageBox.Show("Inserted Successfully!");
                }
            }
            catch (Exception e2)
            {
                //MessageBox.Show(e2.Message);
                MessageBox.Show("Sorry!!Unable to save your prescription"); 
            }


        }

        private void tb_apNo_TextChanged(object sender, EventArgs e)
        {
           using (HMSEntities1 context = new HMSEntities1())
                {   var res = context.Appointments.Select(obj=>obj.appointId);
                    foreach (int i in res)
                    {
                        tb_apNo.AutoCompleteCustomSource.Add(i.ToString());
                    }
                }
                  }

        
    }
}
