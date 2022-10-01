using CProject.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace CProject.AdminPage
{
    public partial class ReceptionistForm : Form
    {
        int option;
        int receptionistId;

        public ReceptionistForm(string header)
        {
            //if add button clicked
            InitializeComponent();
            lbl_header.Text = header;
            option = 2;
        }

        public ReceptionistForm(int id, int option)
        {
            InitializeComponent();
            loadData(id);

            //If Details button clicked
            if (option == 0)
            {
                lbl_header.Text = "Receptionist Details";
                this.option = 0;

            }
            //If edit button clicked
            else if (option == 1)
            {
                lbl_header.Text = "Edit Receptionist";
                this.option = 1;
                receptionistId = id;


            }


        }
        private void loadData(int id)
        {
            HMSDataSet dataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spSearchReceptionistByIdTableAdapter spSearchReceptionistByIdTableAdapter = new HMSDataSetTableAdapters.spSearchReceptionistByIdTableAdapter();
            spSearchReceptionistByIdTableAdapter.Fill(dataSet.spSearchReceptionistById, id);

            foreach (var item in dataSet.spSearchReceptionistById)
            {
                txt_firstname.Text = item.firstName.ToString();
                txt_lastname.Text = item.lastName.ToString();
                txt_phone.Text = item.mobileNo.ToString();
                txt_age.Text = item.age.ToString();
                combo_gender.Text = item.gender.ToString();
                txt_email.Text = item.email.ToString();
                txt_address.Text = item.homeAddress.ToString();
                txt_username.Text = item.username.ToString();
                txt_password.Text = item.password.ToString();
            }







        }

        private void addReceptionist()
        {


            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spAddReceptionist", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@email", txt_email.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
          //  sqlCommand.Parameters.AddWithValue("@department", combo_department.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@username", txt_username.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@password", txt_password.Text.Trim());

            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Receptionist Added successfully");

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

       
        private void editReceptionist()
        {
            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spEditReceptionist", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ReceptionistId", receptionistId);
            sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@email", txt_email.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
          //  sqlCommand.Parameters.AddWithValue("@department", combo_department.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@username", txt_username.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@password", txt_password.Text.Trim());

            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Receptionist Updated successfully");

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

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (option == 2)
            {
                addReceptionist();
            }
            if (option == 1)
            {
                editReceptionist();
            }
            if (option == 0)
            {

            }
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {

        }
    }
}
