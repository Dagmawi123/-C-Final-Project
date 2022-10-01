using CProject.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace CProject.AdminPage
{
    public partial class NurseForm : Form
    {
        int option;
        int nurseId;

        public NurseForm(string header)
        {
            //if add button clicked
            InitializeComponent();
            lbl_header.Text = header;
            option = 2;
        }

        public NurseForm(int id, int option)
        {
            InitializeComponent();
            loadData(id);

            //If Details button clicked
            if (option == 0)
            {
                lbl_header.Text = "Nurse Details";
                this.option = 0;

            }
            //If edit button clicked
            else if (option == 1)
            {
                lbl_header.Text = "Edit Nurse";
                this.option = 1;
                nurseId = id;


            }


        }
        private void loadData(int id)
        {
            HMSDataSet dataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spSearchNurseByIdTableAdapter spSearchNurseByIdTableAdapter = new HMSDataSetTableAdapters.spSearchNurseByIdTableAdapter();
            spSearchNurseByIdTableAdapter.Fill(dataSet.spSearchNurseById, id);

            foreach (var item in dataSet.spSearchNurseById)
            {
                txt_firstname.Text = item.firstName.ToString();
                txt_lastname.Text = item.lastName.ToString();
                txt_phone.Text = item.mobileNo.ToString();
                txt_age.Text = item.age.ToString();
                combo_gender.Text = item.gender.ToString();
                txt_email.Text = item.email.ToString();
                txt_address.Text = item.homeAddress.ToString();
              
            }







        }

        private void addNurse()
        {


            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spAddNurse", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@email", txt_email.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
            

            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Nurse Added successfully");

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

        private void editNurse()
        {
            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spEditNurse", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@nurseId", nurseId);
            sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@email", txt_email.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
       

            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Nurse Updated successfully");

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

        private void NurseForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (option == 2)
            {
                addNurse();
            }
            if (option == 1)
            {
                editNurse();
            }
            if (option == 0)
            {

            }
        }
    }
}
