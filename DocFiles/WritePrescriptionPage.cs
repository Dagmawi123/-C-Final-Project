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
using System.Drawing.Printing;

namespace CProject
{
    public partial class WritePrescriptionPage : Form
    {
        public String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true;MultipleActiveResultSets=true";
        public int docId;
        public int medId;
        public String DocName;
        public String str;
        public String PName;
        public WritePrescriptionPage(String name)
        {
            InitializeComponent();
            TopLevel = false;
            TopMost = true;
            DocName = name;
        }

        private void WritePrescriptionPage_Load(object sender, EventArgs e)
        {
            //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
            try
            {
                using (SqlConnection sc = new SqlConnection(ConString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("[spLoadMed]", sc);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Meds");

                    //cb_Meds.DataSource = ds.Tables["Meds"].Columns[0];

                    List<String> ls = new List<string>();
                    foreach (DataRow d in ds.Tables["Meds"].Rows) {
                        ls.Add(d[0].ToString());
                    }
                    cb_Meds.DataSource = ls;
                }
            }
            catch (Exception e1)
            {
                //MessageBox.Show("Sorry!Unable to load Medicines!");
                MessageBox.Show(e1.Message);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ////MessageBox.Show(e.ToString());
            //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
            //try
            //{
            //    using (SqlConnection s = new SqlConnection(ConString))
            //    {
            //        s.Open();
            //        // String query = "Insert into Prescription values(@ptID,@docId,@mid,@dose,@date)";
            //        SqlCommand cmd = new SqlCommand("[spAddPrescription]", s);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        SqlCommand cmd1 = new SqlCommand("[spMedIdByName]", s);
            //        cmd1.CommandType = CommandType.StoredProcedure;
            //        cmd1.Parameters.AddWithValue("@medName", tb_mname.Text);
            //        //cmd1.Parameters.Add("@id");
            //        cmd1.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

            //    //    cmd1.Parameters["@id"].Direction = ParameterDirection.Output;
            //        cmd1.ExecuteScalar();
            //        medId = int.Parse(cmd1.Parameters["@id"].Value.ToString());

            //        //if (medId > 0) { MessageBox.Show("Medicine id retrieved"); }
            //        SqlCommand cmd2 = new SqlCommand("[spDocIdByName]", s);
            //        cmd2.CommandType = CommandType.StoredProcedure;
            //        cmd2.Parameters.AddWithValue("@name", DocName);
            //        cmd2.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            //       // cmd2.Parameters["@id"].Direction = ParameterDirection.Output;
            //        cmd2.ExecuteScalar();
            //        docId = int.Parse(cmd2.Parameters["@id"].Value.ToString());


            //       // cmd2.ExecuteScalar();
            //        // if (docId > 0) { MessageBox.Show("DoctorId retrieved"); }
            //        cmd.Parameters.AddWithValue("@ptID", SqlDbType.VarChar).Value = tb_Pid.Text;
            //        cmd.Parameters.AddWithValue("@docId", SqlDbType.VarChar).Value = docId;
            //        cmd.Parameters.AddWithValue("@mid", SqlDbType.VarChar).Value = medId;
            //        cmd.Parameters.AddWithValue("@dose", SqlDbType.VarChar).Value = tb_dose.Text;

            //        // cmd.ExecuteNonQuery();
            //        int c = (int)cmd.ExecuteNonQuery();
            //        MessageBox.Show(c.ToString() + " Number of rows inserted Successfully");
            //    }
            //}
            //catch (Exception e2)
            //{ MessageBox.Show("Sorry!!Unable to save your prescription"); 
            //  //  MessageBox.Show(e2.Message);
            //}
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show(e.ToString());
        //    //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
        //    try
        //    {
        //        using (SqlConnection s = new SqlConnection(ConString))
        //        {
        //            s.Open();
        //            // String query = "Insert into Prescription values(@ptID,@docId,@mid,@dose,@date)";
        //            SqlCommand cmd = new SqlCommand("[spAddPrescription]", s);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlCommand cmd1 = new SqlCommand("[spMedIdByName]", s);
        //            cmd1.CommandType = CommandType.StoredProcedure;
        //            cmd1.Parameters.AddWithValue("@medName", tb_mname.Text);
        //            //cmd1.Parameters.Add("@id");
        //            cmd1.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

        //            //    cmd1.Parameters["@id"].Direction = ParameterDirection.Output;
        //            cmd1.ExecuteScalar();
        //            medId = int.Parse(cmd1.Parameters["@id"].Value.ToString());

        //            //if (medId > 0) { MessageBox.Show("Medicine id retrieved"); }
        //            SqlCommand cmd2 = new SqlCommand("[spDocIdByName]", s);
        //            cmd2.CommandType = CommandType.StoredProcedure;
        //            cmd2.Parameters.AddWithValue("@name", DocName);
        //            cmd2.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
        //            // cmd2.Parameters["@id"].Direction = ParameterDirection.Output;
        //            cmd2.ExecuteScalar();
        //            docId = int.Parse(cmd2.Parameters["@id"].Value.ToString());


        //            // cmd2.ExecuteScalar();
        //            // if (docId > 0) { MessageBox.Show("DoctorId retrieved"); }
        //            cmd.Parameters.AddWithValue("@ptID", SqlDbType.VarChar).Value = tb_Pid.Text;
        //            cmd.Parameters.AddWithValue("@docId", SqlDbType.VarChar).Value = docId;
        //            cmd.Parameters.AddWithValue("@mid", SqlDbType.VarChar).Value = medId;
        //            cmd.Parameters.AddWithValue("@dose", SqlDbType.VarChar).Value = tb_dose.Text;

        //            // cmd.ExecuteNonQuery();
        //            int c = (int)cmd.ExecuteNonQuery();
        //            MessageBox.Show(c.ToString() + " Number of rows inserted Successfully");
        //        }
        //    }
        //    catch (Exception e2)
        //    {
        //        MessageBox.Show("Sorry!!Unable to save your prescription");
        //        //  MessageBox.Show(e2.Message);
        //    }
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print();
            }
        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawString(tb_mname.Text,new Font("Times New Roman",12,FontStyle.Bold),Brushes.Black,new PointF(100,100));
        //}

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(e.ToString());
            //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
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
                    cmd1.Parameters.AddWithValue("@medName",cb_Meds.SelectedItem.ToString());//this needs to be modified
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
                    if(c>0)
                    MessageBox.Show( "Inserted Successfully");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Sorry!!Unable to save your prescription..There is no patient with that ID");
                //  MessageBox.Show(e2.Message);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select dbo.PatNameById(" + tb_Pid.Text + ")", con);
                     PName = (String)cmd.ExecuteScalar();
                    
                }
            }
            catch (Exception sq) { MessageBox.Show("Unable to retrieve patient data."); return; }


                str += "***********Prescrption Form To be given For A patient************\n\n\n\n ";
            str += "Patient Name  -"+PName+"\n\n\n\n";
            str += "Medicine Name  -  " + cb_Meds.SelectedItem.ToString()+"\n\n\n";
            str+= "\n\n"+"How would you take the medicine  -  "+tb_dose.Text;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("100 x 100 mm", 400, 400);
            e.Graphics.DrawString(str.ToString(), new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Blue,50,70);
        }
    }

   
    }

