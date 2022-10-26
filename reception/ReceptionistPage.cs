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
using CProject.Database;
using CProject.AdminPage;
using System.IO;



namespace CProject.MainPage
{
    public partial class ReceptionistPage : Form
    {
        HMSDataSet hMSDataSet = new HMSDataSet();

        DataTable dtAppointments = new DataTable();
        DataTable dtRegistration = new DataTable();
        DataTable dtPrescriptions = new DataTable();

        // This will get the current PROJECT directory
        static readonly string workingDirectory = Environment.CurrentDirectory;
        static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;



        public ReceptionistPage()
        {
            InitializeComponent();
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.View_Doctors' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'hMSDataSet.Doctor' table. You can move, or remove it, as needed.


            //maximize the window to the taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Appointments Columns
            dtAppointments.Columns.Add("Id", typeof(int));
            dtAppointments.Columns.Add("Date", typeof(string));
            dtAppointments.Columns.Add("Patient", typeof(string));
            dtAppointments.Columns.Add("Doctor", typeof(string));
            dtAppointments.Columns.Add("Nurse", typeof(string));
            dtAppointments.Columns.Add("Room", typeof(int));
            dtAppointments.Columns.Add("Status", typeof(string));
            //Registration Columns
            dtRegistration.Columns.Add("Id", typeof(int));
            dtRegistration.Columns.Add("Reg. Date", typeof(string));
            dtRegistration.Columns.Add("FirstName", typeof(string));
            dtRegistration.Columns.Add("LastName", typeof(string));
            dtRegistration.Columns.Add("Phone", typeof(string));
            dtRegistration.Columns.Add("Gender", typeof(string));
            dtRegistration.Columns.Add("Age", typeof(int));
            dtRegistration.Columns.Add("BloodType", typeof(string));
            //Prescription Columns
            dtPrescriptions.Columns.Add("Id", typeof(int));
            dtPrescriptions.Columns.Add("Date", typeof(string));
            dtPrescriptions.Columns.Add("Patient", typeof(string));
            dtPrescriptions.Columns.Add("Doctor", typeof(string));
            dtPrescriptions.Columns.Add("Status", typeof(string));
            
            
    
            //open the dashboard panel
            lbl_dashboard_Click(sender,e);

   

        }

        private void loadAppointmentsTable()
        {
            
            HMSDataSetTableAdapters.spViewAppointmentsTableAdapter spViewAppointmentsTableAdapter = new HMSDataSetTableAdapters.spViewAppointmentsTableAdapter();


            spViewAppointmentsTableAdapter.Fill(hMSDataSet.spViewAppointments);

            tbl_appointments.Rows.Clear();
            dtAppointments.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewAppointments.Rows.Count; i++)
            {
                dtAppointments.NewRow();

                dtAppointments.Rows.Add(
                            hMSDataSet.spViewAppointments[i].appointId,
                            hMSDataSet.spViewAppointments[i].dateof,
                            hMSDataSet.spViewAppointments[i].Patient,
                            hMSDataSet.spViewAppointments[i].Doctor,
                            hMSDataSet.spViewAppointments[i].Nurse,
                            hMSDataSet.spViewAppointments[i].roomNo,
                            hMSDataSet.spViewAppointments[i].Status
                             );

            }

        }

        private void loadRegistrationTable()
        {
           
            HMSDataSetTableAdapters.spViewPatientTableAdapter spViewPatientTableAdapter = new HMSDataSetTableAdapters.spViewPatientTableAdapter();


            spViewPatientTableAdapter.Fill(hMSDataSet.spViewPatient);

            tbl_registration.Rows.Clear();
            dtRegistration.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewPatient.Rows.Count; i++)
            {
                dtRegistration.NewRow();

                dtRegistration.Rows.Add(
                            hMSDataSet.spViewPatient[i].patientId,
                             hMSDataSet.spViewPatient[i].dateAdded,
                            hMSDataSet.spViewPatient[i].firstName,
                            hMSDataSet.spViewPatient[i].lastName,
                            hMSDataSet.spViewPatient[i].mobileNo,
                            hMSDataSet.spViewPatient[i].gender,
                            hMSDataSet.spViewPatient[i].age
                           
                             );

            }

        }

        private void loadPrescriptionTable()
        {
           
            HMSDataSetTableAdapters.spViewPrescriptionsTableAdapter spViewPrescriptionsTableAdapter = new HMSDataSetTableAdapters.spViewPrescriptionsTableAdapter();


            spViewPrescriptionsTableAdapter.Fill(hMSDataSet.spViewPrescriptions);

            tbl_prescriptions.Rows.Clear();
            dtPrescriptions.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewPrescriptions.Rows.Count; i++)
            {
                dtPrescriptions.NewRow();

                dtPrescriptions.Rows.Add(
                            hMSDataSet.spViewPrescriptions[i].prescId,
                            hMSDataSet.spViewPrescriptions[i].dateof,
                            hMSDataSet.spViewPrescriptions[i].Patient,
                            hMSDataSet.spViewPrescriptions[i].Doctor,
                            hMSDataSet.spViewPrescriptions[i].Status
                             );

            }

        }

    

        private void navigationButtons1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
            //change the color of the label text
            lbl_dashboard.ForeColor = Color.Black;
            lbl_appointments.ForeColor = Color.DarkGray;
            lbl_registration.ForeColor = Color.DarkGray;
            lbl_prescriptions.ForeColor = Color.DarkGray;
         

            indicator.Location = new Point(172,175);

            HomePage.SetPage(0);

        }

        private void lbl_appointments_Click(object sender, EventArgs e)
        {
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_appointments.ForeColor = Color.Black;
            lbl_registration.ForeColor = Color.DarkGray;
            lbl_prescriptions.ForeColor = Color.DarkGray;
       

            indicator.Location = new Point(172, 259);

            loadAppointmentsTable();

           
            foreach (DataRow dr in dtAppointments.Rows)
            {
                tbl_appointments.Rows.Add(dr.ItemArray);
            }


            HomePage.SetPage(2);
 
        }

        private void lbl_registration_Click(object sender, EventArgs e)
        {
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_appointments.ForeColor = Color.DarkGray;
            lbl_registration.ForeColor = Color.Black;
            lbl_prescriptions.ForeColor = Color.DarkGray;
         

            indicator.Location = new Point(172, 217);

            loadRegistrationTable();

            foreach (DataRow dr in dtRegistration.Rows)
            {
                tbl_registration.Rows.Add(dr.ItemArray);
            }


            HomePage.SetPage(1);

        }

        private void lbl_prescriptions_Click(object sender, EventArgs e)
        {
            
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_appointments.ForeColor = Color.DarkGray;
            lbl_registration.ForeColor = Color.DarkGray;
            lbl_prescriptions.ForeColor = Color.Black;
          

            indicator.Location = new Point(172, 301);

            loadPrescriptionTable();

            foreach (DataRow dr in dtPrescriptions.Rows)
            {
                tbl_prescriptions.Rows.Add(dr.ItemArray);
            }


            HomePage.SetPage(3);

        }

   
        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

       

        private void tbl_doctors_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          //the code below adds image to the buttons int the datagridview
            if (e.RowIndex < 0)
                return;

            //Edit Column image
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string imagepath = "\\Icons\\edit.png";
                Image image = Image.FromFile(projectDirectory + imagepath);

                var w = image.Width-70;
                var h = image.Height-70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            //details column image
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string imagepath = "\\Icons\\details.png";
                Image image = Image.FromFile(projectDirectory + imagepath);

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            //appoint column image
            if (e.ColumnIndex == 9)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string imagepath = "\\Icons\\appoint.png";
               Image image = Image.FromFile(projectDirectory+imagepath);

               // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\delete.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;

                
            }
        }

        private void tbl_doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            var senderGrid = (DataGridView)sender;
           
            //details button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

            }

            //edit button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

               
                lbl_appointments_Click(sender, e);
                
            }

            //delete button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 9 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Doctor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    SqlConnection con = DBService.ConnectDb();
                    SqlCommand sqlCommand = new SqlCommand("spDeleteDoctor", con);


                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@doctorId", id);
                 

                    sqlCommand.Connection = con;

                    try

                    {

                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Doctor Deleted successfully");
                        lbl_appointments_Click(sender, e);

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
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

                
            }
        }

        private void btn_addDoctor_Click(object sender, EventArgs e)
        {


            
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            try
            {
                loadAppointmentsTable();

                var rows = dtAppointments.Select(string.Format("FirstName LIKE '%{0}%' ", txt_doctor_search.Text));
             

                foreach (DataRow dr in rows)
                {
                    tbl_appointments.Rows.Add(dr.ItemArray);
                }

                tbl_appointments.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbl_patient_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //the code below adds image to the buttons int the datagridview
            if (e.RowIndex < 0)
                return;

            //Edit Column image
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string imagepath = "\\Icons\\edit.png";
                Image image = Image.FromFile(projectDirectory + imagepath);

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            //details column image
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string imagepath = "\\Icons\\details.png";
                Image image = Image.FromFile(projectDirectory + imagepath);

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            //delete column image
            if (e.ColumnIndex == 9)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string imagepath = "\\Icons\\appoint.png";
                Image image = Image.FromFile(projectDirectory + imagepath);

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;


            }
        }

        private void tbl_patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            var senderGrid = (DataGridView)sender;

            //details button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                PatientForm patientdetails = new PatientForm(id, 0);
                patientdetails.Show();
                lbl_registration_Click(sender, e);



            }

            //edit button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                PatientForm patientedit = new PatientForm(id, 1);
                patientedit.Show();
                lbl_registration_Click(sender, e);

            }

            //appoint button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 9 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                AppointmentForm appointmentform = new AppointmentForm();
                appointmentform.Show();
                lbl_registration_Click(sender, e);


            }
        }

        private void tbl_receptionist_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //the code below adds image to the buttons int the datagridview
            if (e.RowIndex < 0)
                return;

            //Edit Column image
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);


                string imagepath = "\\Icons\\give.png";
                Image image = Image.FromFile(projectDirectory + imagepath);


                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
         

        }

        private void tbl_receptionist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            var senderGrid = (DataGridView)sender;

            //give button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 5 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

               
                //lbl_receptionist_Click(sender, e);


            }

        
        }

        
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
     
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
   
        }
        int depid;

  
        private void bunifuButton8_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {
            AppointmentForm appointmentform = new AppointmentForm();
            appointmentform.Show();
        }
    }
    }
