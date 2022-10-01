using CProject.Database;
using System;
using System.Data;
using System.Data.SqlClient;
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

        private void editDoctor()
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

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorDetails_Load(object sender, EventArgs e)
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
