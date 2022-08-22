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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(cb_utype.SelectedText);
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;
            SqlDataReader reader;
            bool t = false;

            connectionString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
            if (cb_utype.SelectedText.Equals("ADMIN"))
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
            else if (cb_utype.SelectedText.Equals("RECEPTIONIST"))
            {
                sql = " Select * from Receptionist";


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
            else if (cb_utype.SelectedText.Equals("DOCTOR"))
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
            else
                MessageBox.Show("Please Select appropriate user type");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
    }
    

