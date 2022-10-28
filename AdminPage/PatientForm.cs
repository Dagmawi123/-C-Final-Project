using CProject.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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

        private bool validate()
        {
            bool v = true;

            //validate firstname textbox
            Regex rgxname = new Regex(@"^[a-zA-Z][A-Z]*$");
            if (txt_firstname.Text.Equals(""))
            {
                
                errorProvider1.SetError(txt_firstname, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxname.IsMatch(txt_firstname.Text.Trim()))
            {
                errorProvider1.SetError(txt_firstname, "Incorrect Format");
                v=false;
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
            Regex rgxage = new Regex(@"^[0-9]$");
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
            Regex rgxaddress = new Regex(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$");
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

            //validate disease
            if (txt_disease.Text.Equals(""))
            {

                errorProvider1.SetError(txt_disease, "Cannot Be Empty");
                v = false;
            }
            else if (!rgxname.IsMatch(txt_disease.Text.Trim()))
            {
                errorProvider1.SetError(txt_disease, "Incorrect Format");
                v = false;
            }
            else
                errorProvider1.SetError(txt_disease, "");

            //validate blood group
            if (combo_blood.Text.Equals(""))
            {

                errorProvider1.SetError(combo_blood, "Cannot Be Empty");
                v = false;
            }
            else
                errorProvider1.SetError(combo_blood, "");

            //validate gender
            if (combo_gender.Text.Equals(""))
            {

                errorProvider1.SetError(combo_gender, "Cannot Be Empty");
                v = false;
            }
            else
                errorProvider1.SetError(combo_gender, "");

            return v;
        }

        private void addPatient()
        {
            validate();

            if (false)
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
