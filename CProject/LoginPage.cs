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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_see.Checked) {
                tb_pwd.PasswordChar = (char)0;
            }
            else
                tb_pwd.PasswordChar = '@';
        }
        
        private void pictureBox1_Click(object sender, EventArgs e) { 
            if (String.IsNullOrEmpty(tb_uname.Text)) {
              errorProvider1.SetError(tb_uname, "PLEASE ENTER YOUR USER NAME!!");
                errorProvider1 .BlinkRate= 2;
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
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;
            SqlDataReader reader;
            bool t = false;
            int a = cb_utype.SelectedIndex;
            connectionString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";

            // if (cb_utype.SelectedItem.ToString().Equals(null))
            //{
            //  MessageBox.Show("Please Select system user!!");
            //}
            try
            {
                
                if (cb_utype.SelectedItem.ToString().Equals("ADMIN"))
                {
                    sql = " Select * from Admin";


                    try
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        cmd = new SqlCommand(sql, cnn);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Connected!");
                        while (reader.Read())
                        {
                            // MessageBox.Show(reader.GetString(0));
                            if (tb_uname.Text.Equals(reader.GetString(0)))
                            {
                                t = true;
                                if (tb_pwd.Text.Equals(reader.GetString(1).ToString())) { MessageBox.Show("Succesfully logged!!"); }
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
                    sql = " Select * from Receptionist";


                    try
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        cmd = new SqlCommand(sql, cnn);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Connected!");
                        if (!reader.Read()) { MessageBox.Show("There is no receptionist saved in the database");
                            return;
                        }
                        while (reader.Read())
                        {
                            // MessageBox.Show(reader.GetString(0));
                            if (tb_uname.Text.Equals(reader.GetString(2)))
                            {
                                t = true;
                                if (tb_pwd.Text.Equals(reader.GetString(3).ToString())) { MessageBox.Show("Succesfully logged!!"); }
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
                    sql = " Select * from Doctor";


                    try
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        cmd = new SqlCommand(sql, cnn);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Connected!");
                        while (reader.Read())
                        {
                            // MessageBox.Show(reader.GetString(0));
                            if (tb_uname.Text.Equals(reader.GetString(3)))
                            {
                                t = true;
                                if (tb_pwd.Text.Equals(reader.GetString(4).ToString())) { MessageBox.Show("Succesfully logged!!");
                                    this.Hide();
                                    DoctorHomePage d = new DoctorHomePage(tb_uname.Text);
                                    d.Show();
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

        private void cb_utype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    

