using CProject.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace CProject.AdminPage
{
    public partial class DoctorForm : Form
    {
        int option;
        int doctorid;

        public DoctorForm(string header)
        {
            //if add button clicked
            InitializeComponent();
            loadDepartment();
            lbl_header.Text = header;
            option = 2;
        }

        public DoctorForm(int id, int option)
        {
            InitializeComponent();
            loadDepartment();
            loadData(id);

            //If Details button clicked
            if (option == 0)
            {
                lbl_header.Text = "Doctor Details";
                this.option = 0;

            }
            //If edit button clicked
            else if (option == 1)
            {
                lbl_header.Text = "Edit Doctor";
                this.option = 1;
                doctorid = id;


            }


        }
        private void loadData(int id)
        {
            HMSDataSet dataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spSearchDoctorByIdTableAdapter spSearchDoctorByIdTableAdapter = new HMSDataSetTableAdapters.spSearchDoctorByIdTableAdapter();
            spSearchDoctorByIdTableAdapter.Fill(dataSet.spSearchDoctorById, id);

            foreach (var item in dataSet.spSearchDoctorById)
            {
                txt_firstname.Text = item.firstName.ToString();
                txt_lastname.Text = item.lastName.ToString();
                txt_phone.Text = item.mobileNo.ToString();
                txt_age.Text = item.age.ToString();
                combo_gender.Text = item.gender.ToString();
                txt_email.Text = item.email.ToString();
                txt_address.Text = item.homeAddress.ToString();
                combo_department.Text = item.Name.ToString();
                txt_username.Text = item.username.ToString();
                txt_password.Text = item.password.ToString();
            }







        }

        private void addDoctor()

        {

            if (validate())
            {

                SqlConnection con = DBService.ConnectDb();
                SqlCommand sqlCommand = new SqlCommand("spAddDoctor", con);


                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@email", txt_email.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@department", combo_department.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@password", txt_password.Text.Trim());

                sqlCommand.Connection = con;

                try

                {

                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Doctor Added successfully");

                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.ToString());

                    // throw ex;

                }
                finally
                {
                    con.Close();
                }

            }

        }

        private void loadDepartment()
        {
            HMSDataSet hMSDataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spGetAllDepartmentTableAdapter spGetAllDepartmentTableAdapter = new HMSDataSetTableAdapters.spGetAllDepartmentTableAdapter();
            spGetAllDepartmentTableAdapter.Fill(hMSDataSet.spGetAllDepartment);
            foreach (var row in hMSDataSet.spGetAllDepartment)
            {
                // row.Name
                // combo_department.Items.Add(hMSDataSet.spGetAllDepartment.NameColumn);
                combo_department.Items.Add(row.Name.ToString());

            }

        }

        private bool validate()
        {
            bool v = true;

            //validate firstname textbox
            Regex rgxname = new Regex(@"^[a-zA-Z]+$");
            if (txt_firstname.Text.Equals(""))
            {

                errorProvider1.SetError(txt_firstname, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxname.IsMatch(txt_firstname.Text.Trim()))
            {
                errorProvider1.SetError(txt_firstname, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_firstname, "");

            //validate lastname textbox
            if (txt_lastname.Text.Equals(""))
            {

                errorProvider1.SetError(txt_lastname, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxname.IsMatch(txt_lastname.Text.Trim()))
            {
                errorProvider1.SetError(txt_lastname, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_lastname, "");


            //validate phone textbox
            Regex rgxphone = new Regex(@"^[0-9]{10}$");
            if (txt_phone.Text.Equals(""))
            {

                errorProvider1.SetError(txt_phone, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxphone.IsMatch(txt_phone.Text.Trim()))
            {
                errorProvider1.SetError(txt_phone, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_phone, "");

            //validate age textbox
            Regex rgxage = new Regex(@"^[0-9]*$");
            if (txt_age.Text.Equals(""))
            {

                errorProvider1.SetError(txt_age, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxage.IsMatch(txt_age.Text.Trim()))
            {
                errorProvider1.SetError(txt_age, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_age, "");

            //validate address
            Regex rgxaddress = new Regex(@".{3,}");
            if (txt_address.Text.Equals(""))
            {

                errorProvider1.SetError(txt_address, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxaddress.IsMatch(txt_address.Text.Trim()))
            {
                errorProvider1.SetError(txt_address, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_address, "");

            //validate email 
            bool isValidEmail(string emailaddress)
            {
                try
                {
                    MailAddress m = new MailAddress(emailaddress);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }

            if (txt_email.Text.Equals(""))
            {

                errorProvider1.SetError(txt_email, "Cannot Be Empty");
                v = false;
            }
            else if (!isValidEmail(txt_email.Text))
            {
                errorProvider1.SetError(txt_email, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_email, "");

            //validate username
            Regex rgxusername = new Regex(@"^[a-zA-Z0-9_]+$");
            if (txt_username.Text.Equals(""))
            {

                errorProvider1.SetError(txt_username, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxusername.IsMatch(txt_username.Text.Trim()))
            {
                errorProvider1.SetError(txt_username, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_username, "");


            //validate password
            Regex rgxpassword = new Regex(@".{4,}");
            if (txt_password.Text.Equals(""))
            {

                errorProvider1.SetError(txt_password, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxpassword.IsMatch(txt_password.Text.Trim()))
            {
                errorProvider1.SetError(txt_password, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_password, "");


            //validate gender
            if (combo_gender.Text.Equals(""))
            {

                errorProvider1.SetError(combo_gender, "Cannot Be Empty");
                v = false;
            }
            else
                errorProvider1.SetError(combo_gender, "");

            //validate department
            if (combo_department.Text.Equals(""))
            {

                errorProvider1.SetError(combo_department, "Cannot Be Empty");
                v = false;
            }
            else
                errorProvider1.SetError(combo_department, "");

            return v;
        }

        private void editDoctor()
        {
            if (validate())
            {
                SqlConnection con = DBService.ConnectDb();
                SqlCommand sqlCommand = new SqlCommand("spEditDoctor", con);


                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@doctorId", doctorid);
                sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@email", txt_email.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@department", combo_department.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@password", txt_password.Text.Trim());

                sqlCommand.Connection = con;

                try

                {

                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated successfully");

                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.ToString());

                    // throw ex;

                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (option == 2)
            {
                addDoctor();
            }
            if (option == 1)
            {
                editDoctor();
            }
            if (option == 0)
            {

            }
        }
    }
}
