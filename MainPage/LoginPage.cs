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

namespace CProject.MainPage
{
    public partial class LoginPage : Form
    {
        //public Form2 newForm = null;
            public LoginPage()
        {
            InitializeComponent();
        }
        //public LoginPage(Form2 sentForm)
        //{
        //    InitializeComponent();
        //    newForm = sentForm;
        //  //  newForm.Dispose();
        //}
      public const String  connectionString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_see.Checked)
            {
                tb_pwd.PasswordChar = (char)0;
            }
            else
                tb_pwd.PasswordChar = '@';
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(tb_uname.Text))
        //    {
        //        errorProvider1.SetError(tb_uname, "PLEASE ENTER YOUR USER NAME!!");
        //        errorProvider1.BlinkRate = 2;
        //        return;
        //    }
        //    else if (String.IsNullOrEmpty(tb_pwd.Text))
        //    {
        //        errorProvider1.SetError(tb_pwd, "PLEASE ENTER YOUR PASSWORD HERE!!");
        //        errorProvider1.BlinkRate = 2;
        //        return;
        //    }
        //    else errorProvider1.Clear();
        //    // MessageBox.Show(cb_utype.SelectedText);
        //    //string connectionString = null;
        //    SqlConnection cnn;
        //    SqlCommand cmd;
        //    string sql = null;
        //    SqlDataReader reader;
        //    bool t = false;
        //    int a = cb_utype.SelectedIndex;
        //    //connectionString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";

        //    // if (cb_utype.SelectedItem.ToString().Equals(null))
        //    //{
        //    //  MessageBox.Show("Please Select system user!!");
        //    //}
        //    try
        //    {

        //        if (cb_utype.SelectedItem.ToString().Equals("ADMIN"))
        //        {
        //            sql = " Select * from Admin";


        //            try
        //            {
        //                cnn = new SqlConnection(connectionString);
        //                cnn.Open();
        //                cmd = new SqlCommand(sql, cnn);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                reader = cmd.ExecuteReader();
        //                if (!reader.Read())
        //                {
        //                    MessageBox.Show("There is no Admin saved in the database");
        //                    return;
        //                }
        //                MessageBox.Show("Connected!");
        //                while (reader.Read())
        //                {
        //                    // MessageBox.Show(reader.GetString(0));
        //                    if (tb_uname.Text.Equals(reader.GetString(0)))
        //                    {
        //                        t = true;
        //                        if (tb_pwd.Text.Equals(reader.GetString(1).ToString())) { MessageBox.Show("Succesfully logged!!"); }
        //                        else
        //                        {
        //                            MessageBox.Show("Incorrect Credential");
        //                        }


        //                    }

        //                }

        //                if (!t)
        //                {

        //                    MessageBox.Show("Admin " + tb_uname.Text + " does not exist");

        //                }
        //                reader.Close();
        //                cmd.Dispose();
        //                cnn.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Can not open connection ! ");
        //            }
        //        }
        //        else if (cb_utype.SelectedItem.ToString().Equals("RECEPTIONIST"))
        //        {
        //            sql = " Select * from Receptionist";


        //            try
        //            {
        //                cnn = new SqlConnection(connectionString);
        //                cnn.Open();
        //                cmd = new SqlCommand(sql, cnn);
        //                reader = cmd.ExecuteReader();
        //                MessageBox.Show("Connected!");
        //                if (!reader.Read())
        //                {
        //                    MessageBox.Show("There is no receptionist saved in the database");
        //                    return;
        //                }
        //                while (reader.Read())
        //                {
        //                    // MessageBox.Show(reader.GetString(0));
        //                    if (tb_uname.Text.Equals(reader.GetString(2)))
        //                    {
        //                        t = true;
        //                        if (tb_pwd.Text.Equals(reader.GetString(3).ToString())) { MessageBox.Show("Succesfully logged!!"); }
        //                        else
        //                        {
        //                            MessageBox.Show("Incorrect password");
        //                        }


        //                    }

        //                }

        //                if (!t)
        //                {

        //                    MessageBox.Show("Receptionist " + tb_uname.Text + " does not exist");

        //                }
        //                reader.Close();
        //                cmd.Dispose();
        //                cnn.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("could not open connection ! ");
        //            }
        //        }
        //        else if (cb_utype.SelectedItem.ToString().Equals("DOCTOR"))
        //        {
        //            sql = " Select * from Doctor";


        //            try
        //            {
        //                cnn = new SqlConnection(connectionString);
        //                cnn.Open();
        //                cmd = new SqlCommand(sql, cnn);
        //                reader = cmd.ExecuteReader();
        //                MessageBox.Show("Connected!");
        //                while (reader.Read())
        //                {
        //                    // MessageBox.Show(reader.GetString(0));
        //                    if (tb_uname.Text.Equals(reader.GetString(3)))
        //                    {
        //                        t = true;
        //                        if (tb_pwd.Text.Equals(reader.GetString(4).ToString()))
        //                        {
        //                            MessageBox.Show("Succesfully logged!!");
        //                            this.Hide();
        //                            //Form f = LoginPage.ActiveForm;
        //                            MainPage.DoctorPage d = new MainPage.DoctorPage(tb_uname.Text, this);
        //                            d.Show();
        //                            //f.Close();
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Incorrect password");
        //                        }


        //                    }

        //                }

        //                if (!t)
        //                {

        //                    MessageBox.Show("Doctor " + tb_uname.Text + " does not exist");

        //                }
        //                reader.Close();
        //                cmd.Dispose();
        //                cnn.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Can not open connection ! ");
        //            }
        //        }
        //    }
        //    catch (Exception ewq)
        //    {
        //        MessageBox.Show("Please Select appropriate user type");
        //    }



        //}

        private void cb_utype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  newForm.Dispose();
        }

        //private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    newForm.Dispose();
        //}

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_uname.Text))
            {
                errorProvider1.SetError(tb_uname, "PLEASE ENTER YOUR USER NAME!!");
                errorProvider1.BlinkRate = 2;
                return;
            }
            else if (String.IsNullOrEmpty(tb_pwd.Text))
            {
                errorProvider1.SetError(tb_pwd, "PLEASE ENTER YOUR PASSWORD HERE!!");
                errorProvider1.BlinkRate = 2;
                return;
            }
            else errorProvider1.Clear();
            // MessageBox.Show(cb_utype.SelectedText);
            //string connectionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            //string sql = null;
            SqlDataReader reader;
            bool t = false;
            int a = cb_utype.SelectedIndex;

            // if (cb_utype.SelectedItem.ToString().Equals(null))
            //{
            //  MessageBox.Show("Please Select system user!!");
            //}
            try
            {

                if (cb_utype.SelectedItem.ToString().Equals("ADMIN"))
                {
                    //sql = " Select * from Admin";


                    try
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        cmd = new SqlCommand("[spSelectAdmins]", cnn);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Connected!");
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("There is no Doctor data saved in the database");
                            return;
                        }
                        while (reader.Read())
                        {
                            // MessageBox.Show(reader.GetString(0));
                            if (tb_uname.Text.Equals(reader.GetString(0)))
                            {
                                t = true;
                                if (tb_pwd.Text.Equals(reader.GetString(1).ToString())) { MessageBox.Show("Succesfully logged!!");
                                    AdminPage ad = new AdminPage();
                                    ad.Show();
                                    this.Hide();
                                }

                                else
                                {
                                    MessageBox.Show("Incorrect password");
                                }


                            }

                        }

                        if (!t)
                        {

                            MessageBox.Show("Admin " + tb_uname.Text + " does not exist");

                        }
                        reader.Close();
                        cmd.Dispose();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
                else if (cb_utype.SelectedItem.ToString().Equals("RECEPTIONIST"))
                {
                  //  sql = " Select * from Receptionist";


                    try
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        cmd = new SqlCommand("[spSelectRecep]", cnn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Connected!");
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("There is no receptionist saved in the database");
                            return;
                        }
                        while (reader.Read())
                        {
                            // MessageBox.Show(reader.GetString(0));
                            if (tb_uname.Text.Equals(reader.GetString(0)))
                            {
                                t = true;
                                if (tb_pwd.Text.Equals(reader.GetString(1).ToString())) { MessageBox.Show("Succesfully logged!!");
                                    ReceptionistPage rp = new ReceptionistPage();
                                    rp.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password");
                                }


                            }

                        }

                        if (!t)
                        {

                            MessageBox.Show("Receptionist " + tb_uname.Text + " does not exist");

                        }
                        reader.Close();
                        cmd.Dispose();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
                else if (cb_utype.SelectedItem.ToString().Equals("DOCTOR"))
                {
                   String sql = " Select * from Doctor";


                    try
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        cmd = new SqlCommand(sql, cnn);
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("There is no Doctor data saved in the database");
                            return;
                        }
                        MessageBox.Show("Connected!");
                        while (reader.Read())
                        {
                            //MessageBox.Show(reader.GetString(3));
                            if (tb_uname.Text.Equals(reader.GetString(3)))
                            {
                                t = true;
                                if (tb_pwd.Text.Equals(reader.GetString(4).ToString()))
                                {
                                    MessageBox.Show("Succesfully logged!!");
                                    this.Hide();
                                    //Form f = LoginPage.ActiveForm;
                                    MainPage.DoctorPage d = new MainPage.DoctorPage(tb_uname.Text, this);
                                    d.Show();
                                    //f.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password");
                                }


                            }

                        }

                        if (!t)
                        {

                            MessageBox.Show("Doctor " + tb_uname.Text + " does not exist");

                        }
                        reader.Close();
                        cmd.Dispose();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
            }
            catch (Exception ewq)
            {
                MessageBox.Show("Please Select appropriate user type");
            }
        }

        private void LoginPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }

        /*  private void lbl_add_Click(object sender, EventArgs e)
          {
           try
              {
                  int x = 0;
                  String query = "exec AddAdmin " + tb_uname.Text + " ," + tb_pwd.Text;
                  String connectionString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Integrated security=true;";
                  SqlConnection cnn = new SqlConnection(connectionString);
                  SqlCommand cmd = new SqlCommand(query, cnn);
                  cnn.Open();
                  x = (int)cmd.ExecuteNonQuery();
                  if (x > 0) { MessageBox.Show("Admin Inserted Sucessfully"); }
                  else { MessageBox.Show("unable to insert Admin"); }
                  cnn.Close();
              }
              catch (SqlException s)
              {
                  MessageBox.Show("ConnectionError");


              }

          } 
      */
    }
    }
    

