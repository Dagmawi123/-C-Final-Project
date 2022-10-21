using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CProject.Database;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CProject.AdminPage
{

    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
            loadtobox();
        }

        public AppointmentForm(int id)
        {
            InitializeComponent();
            loadtobox();
            loadpatient(id);

        }


        private void AppointmentForm_Load(object sender, EventArgs e)
        {
        
        }

        private void loadtobox()
        {
           
            HMSDataSet hMSDataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spDoctorListTableAdapter spDoctorListTableAdapter = new HMSDataSetTableAdapters.spDoctorListTableAdapter();
            spDoctorListTableAdapter.Fill(hMSDataSet.spDoctorList);
            foreach (var row in hMSDataSet.spDoctorList)
            {
               
                cmb_doctor.Items.Add(row.doctorId.ToString() + " " + row.Doctor.ToString()+" "+ row.Name.ToString() );

            }

            HMSDataSetTableAdapters.spPatientListTableAdapter spPatientListTableAdapter = new HMSDataSetTableAdapters.spPatientListTableAdapter();
            spPatientListTableAdapter.Fill(hMSDataSet.spPatientList);
            foreach (var row in hMSDataSet.spPatientList)
            {
           
                cmb_patient.Items.Add(row.patientId.ToString()+" "+ row.Patient.ToString());

            }

            HMSDataSetTableAdapters.spNurseListTableAdapter spNurseListTableAdapter = new HMSDataSetTableAdapters.spNurseListTableAdapter();
            spNurseListTableAdapter.Fill(hMSDataSet.spNurseList);
            foreach (var row in hMSDataSet.spNurseList)
            {
               
                cmb_nurse.Items.Add(row.nurseId.ToString() + " " + row.Nurse.ToString());

            }

            HMSDataSetTableAdapters.spRoomListTableAdapter spRoomListTableAdapter = new HMSDataSetTableAdapters.spRoomListTableAdapter();
            spRoomListTableAdapter.Fill(hMSDataSet.spRoomList);
            foreach (var row in hMSDataSet.spRoomList)
            {
            
                cmb_room.Items.Add(row.roomNo.ToString());

            }








        }

        private void loadpatient(int id)
        {
            HMSDataSet dataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spPatientListTableAdapter spPatientListTableAdapter = new HMSDataSetTableAdapters.spPatientListTableAdapter();
            spPatientListTableAdapter.Fill(dataSet.spPatientList);
            foreach (var row in dataSet.spPatientList)
            {
                if(row.patientId==id)
                cmb_patient.Text=row.patientId.ToString() + " " + row.Patient.ToString();

            }




        }
        private bool validate()
        {
            bool v = true;
            if (cmb_doctor.Text.Equals(""))
            {
                
                errorProvider1.SetError(cmb_doctor, "Cannot Be Empty");
                v=false;
            }
            else
                errorProvider1.SetError(cmb_doctor, "");


            if (cmb_patient.Text.Equals(""))
            {
                errorProvider1.SetError(cmb_patient, "Cannot Be Empty");
                v=false;

            }
            else
                errorProvider1.SetError(cmb_patient, "");

            if (cmb_nurse.Text.Equals(""))
            {
                errorProvider1.SetError(cmb_nurse, "Cannot Be Empty");
                v = false;

            }
            else
                errorProvider1.SetError(cmb_nurse, "");

            if (cmb_room.Text.Equals(""))
            {
                errorProvider1.SetError(cmb_room, "Cannot Be Empty");
                v = false;

            }
            else
                errorProvider1.SetError(cmb_room, "");

            return v;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            

            if (validate())
            {
                string patient = cmb_patient.SelectedItem.ToString();
                //gets the id from the combo box using regex
                int patientid = int.Parse(Regex.Match(patient, @"\d+").Value);

                string doctor = cmb_doctor.SelectedItem.ToString();
                int doctorid = int.Parse(Regex.Match(doctor, @"\d+").Value);

                string nurse = cmb_nurse.SelectedItem.ToString();
                int nurseid = int.Parse(Regex.Match(nurse, @"\d+").Value);

                string room = cmb_room.SelectedItem.ToString();
                int roomno = int.Parse(Regex.Match(room, @"\d+").Value);

                string date = dateTimePicker1.Value.ToShortDateString();

                SqlConnection con = DBService.ConnectDb();
                SqlCommand sqlCommand = new SqlCommand("spAddAppointment", con);


                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@patientid", patientid);
                sqlCommand.Parameters.AddWithValue("@doctorid", doctorid);
                sqlCommand.Parameters.AddWithValue("@nurseid", nurseid);
                sqlCommand.Parameters.AddWithValue("@roomno", roomno);
                sqlCommand.Parameters.AddWithValue("@date", date);


                sqlCommand.Connection = con;

                try

                {

                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Appointment Added successfully");

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

        private void resetbtn_Click(object sender, EventArgs e)
        {
            cmb_room.Text = "";
            cmb_patient.Text = "";
            cmb_nurse.Text = "";
            cmb_doctor.Text = "";
           


        }
    }
}
