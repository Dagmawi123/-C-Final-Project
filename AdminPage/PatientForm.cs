using CProject.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace CProject.AdminPage
{
    public partial class PatientForm : Form
    {
        int option;
        int patientid;

        public PatientForm(string header)
        {
            //if add button clicked
            InitializeComponent();
           
            lbl_header.Text = header;
            option = 2;
        }

        public PatientForm(int id, int option)
        {
            InitializeComponent();
            loadData(id);

            //If Details button clicked
            if (option == 0)
            {
                lbl_header.Text = "Patient Details";
                this.option = 0;

            }
            //If edit button clicked
            else if (option == 1)
            {
                lbl_header.Text = "Edit Patient";
                this.option = 1;
                patientid = id;


            }


        }
        private void loadData(int id)
        {
            HMSDataSet dataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spSearchPatientByIdTableAdapter spSearchPatientByIdTableAdapter = new HMSDataSetTableAdapters.spSearchPatientByIdTableAdapter();
            spSearchPatientByIdTableAdapter.Fill(dataSet.spSearchPatientById, id);

            foreach (var item in dataSet.spSearchPatientById)
            {
                txt_firstname.Text = item.firstName.ToString();
                txt_lastname.Text = item.lastName.ToString();
                txt_phone.Text = item.mobileNo.ToString();
                txt_age.Text = item.age.ToString();
                combo_gender.Text = item.gender.ToString();
                txt_disease.Text = item.disease.ToString();
                txt_address.Text = item.Address.ToString();
                combo_blood.Text = item.bloodgroup.ToString();
                
            }







        }

        private void addPatient()
        {


            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spAddPatient", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@disease", txt_disease.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@bloodgroup", combo_blood.Text.Trim());
    

            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Patient Added successfully");

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

        private void editPatient()
        {
            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spEditPatient", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@patientId", patientid);
            sqlCommand.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@mobileno", txt_phone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@gender", combo_gender.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@age", txt_age.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@disease", txt_disease.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@homeAddress", txt_address.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@bloodgroup", combo_blood.Text.Trim());
          

            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Patient Updated successfully");

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

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (option == 2)
            {
                addPatient();
            }
            if (option == 1)
            {
                editPatient();
            }
            if (option == 0)
            {

            }
        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
