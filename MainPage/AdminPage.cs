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
using System.Reflection;

namespace CProject.MainPage
{
    public partial class AdminPage : Form
    {
        DataTable dtDoctor = new DataTable();
        DataTable dtPatient = new DataTable();
        DataTable dtReceptionist = new DataTable();
        DataTable dtNurse = new DataTable();
        DataTable dtDepartment = new DataTable();
       


        public AdminPage()
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

            //Doctor Columns
            dtDoctor.Columns.Add("Id", typeof(int));
            dtDoctor.Columns.Add("FirstName", typeof(string));
            dtDoctor.Columns.Add("LastName", typeof(string));
            dtDoctor.Columns.Add("Phone", typeof(string));
            dtDoctor.Columns.Add("Gender", typeof(string));
            dtDoctor.Columns.Add("Age", typeof(int));
            dtDoctor.Columns.Add("Department", typeof(string));
            //Patient Columns
            dtPatient.Columns.Add("Id", typeof(int));
            dtPatient.Columns.Add("Reg. Date", typeof(string));
            dtPatient.Columns.Add("FirstName", typeof(string));
            dtPatient.Columns.Add("LastName", typeof(string));
            dtPatient.Columns.Add("Phone", typeof(string));
            dtPatient.Columns.Add("Gender", typeof(string));
            dtPatient.Columns.Add("Age", typeof(int));
            dtPatient.Columns.Add("BloodType", typeof(string));
            //Receptionist Columns
            dtReceptionist.Columns.Add("Id", typeof(int));
            dtReceptionist.Columns.Add("FirstName", typeof(string));
            dtReceptionist.Columns.Add("LastName", typeof(string));
            dtReceptionist.Columns.Add("Phone", typeof(string));
            dtReceptionist.Columns.Add("Gender", typeof(string));
            dtReceptionist.Columns.Add("Age", typeof(int));
            dtReceptionist.Columns.Add("Address", typeof(string));
            //Nurse Columns
            dtNurse.Columns.Add("Id", typeof(int));
            dtNurse.Columns.Add("FirstName", typeof(string));
            dtNurse.Columns.Add("LastName", typeof(string));
            dtNurse.Columns.Add("Phone", typeof(string));
            dtNurse.Columns.Add("Gender", typeof(string));
            dtNurse.Columns.Add("Age", typeof(int));
            dtNurse.Columns.Add("Department", typeof(string));
            //Department Columns
            dtDepartment.Columns.Add("Id", typeof(int));
            dtDepartment.Columns.Add("FirstName", typeof(string));
    
            //open the dashboard panel
            lbl_dashboard_Click(sender,e);

   

        }

        private void loadDoctorTable()
        {
            HMSDataSet hMSDataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spViewDoctorTableAdapter spViewDoctorTableAdapter = new HMSDataSetTableAdapters.spViewDoctorTableAdapter();
           

            spViewDoctorTableAdapter.Fill(hMSDataSet.spViewDoctor);

            tbl_doctors.Rows.Clear();
            dtDoctor.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewDoctor.Rows.Count; i++)
            {
                dtDoctor.NewRow();

                dtDoctor.Rows.Add(
                            hMSDataSet.spViewDoctor[i].doctorId,
                            hMSDataSet.spViewDoctor[i].firstName,
                            hMSDataSet.spViewDoctor[i].lastName,
                            hMSDataSet.spViewDoctor[i].mobileNo,
                            hMSDataSet.spViewDoctor[i].gender,
                            hMSDataSet.spViewDoctor[i].age,
                            hMSDataSet.spViewDoctor[i].Name
                             );

            }

        }

        private void loadPatientTable()
        {
            HMSDataSet hMSDataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spViewPatientTableAdapter spViewPatientTableAdapter = new HMSDataSetTableAdapters.spViewPatientTableAdapter();


            spViewPatientTableAdapter.Fill(hMSDataSet.spViewPatient);

            tbl_patient.Rows.Clear();
            dtPatient.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewPatient.Rows.Count; i++)
            {
                dtPatient.NewRow();

                dtPatient.Rows.Add(
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

        private void loadReceptionistTable()
        {
            HMSDataSet hMSDataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spViewReceptionistTableAdapter spViewReceptionistTableAdapter = new HMSDataSetTableAdapters.spViewReceptionistTableAdapter();


            spViewReceptionistTableAdapter.Fill(hMSDataSet.spViewReceptionist);

            tbl_receptionist.Rows.Clear();
            dtReceptionist.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewReceptionist.Rows.Count; i++)
            {
                dtReceptionist.NewRow();

                dtReceptionist.Rows.Add(
                            hMSDataSet.spViewReceptionist[i].rId,
                            hMSDataSet.spViewReceptionist[i].firstName,
                            hMSDataSet.spViewReceptionist[i].lastName,
                            hMSDataSet.spViewReceptionist[i].mobileNo,
                            hMSDataSet.spViewReceptionist[i].gender,
                            hMSDataSet.spViewReceptionist[i].age,
                            hMSDataSet.spViewReceptionist[i].homeAddress
                             );

            }

        }

        private void loadNurseTable()
        {
            HMSDataSet hMSDataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spViewNurseTableAdapter spViewNurseTableAdapter = new HMSDataSetTableAdapters.spViewNurseTableAdapter();


            spViewNurseTableAdapter.Fill(hMSDataSet.spViewNurse);

            tbl_nurse.Rows.Clear();
            dtNurse.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewNurse.Rows.Count; i++)
            {
                dtNurse.NewRow();

                dtNurse.Rows.Add(
                            hMSDataSet.spViewNurse[i].nurseId,
                            hMSDataSet.spViewNurse[i].firstName,
                            hMSDataSet.spViewNurse[i].lastName,
                            hMSDataSet.spViewNurse[i].mobileNo,
                            hMSDataSet.spViewNurse[i].gender,
                            hMSDataSet.spViewNurse[i].age,
                            hMSDataSet.spViewNurse[i].homeAddress
                             );

            }

        }

        private void loadDepartmentTable()
        {
            HMSDataSet hMSDataSet = new HMSDataSet();
            HMSDataSetTableAdapters.spViewDepartmentTableAdapter spViewDepartmentTableAdapter = new HMSDataSetTableAdapters.spViewDepartmentTableAdapter();


            spViewDepartmentTableAdapter.Fill(hMSDataSet.spViewDepartment);

            tbl_department.Rows.Clear();
            dtDepartment.Rows.Clear();

            for (int i = 0; i < hMSDataSet.spViewDepartment.Rows.Count; i++)
            {
                dtDepartment.NewRow();

                dtDepartment.Rows.Add(
                            hMSDataSet.spViewDepartment[i].deptId,
                             hMSDataSet.spViewDepartment[i].Name

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
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;

            indicator.Location = new Point(168,92);

            HomePage.SetPage(0);

        }

        private void lbl_doctors_Click(object sender, EventArgs e)
        {
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.Black;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;

            indicator.Location = new Point(168, 134);

            loadDoctorTable();

           
            foreach (DataRow dr in dtDoctor.Rows)
            {
                tbl_doctors.Rows.Add(dr.ItemArray);
            }


            HomePage.SetPage(1);
 
        }

        private void lbl_patients_Click(object sender, EventArgs e)
        {
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.Black;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;

            indicator.Location = new Point(168, 176);

            loadPatientTable();

            foreach (DataRow dr in dtPatient.Rows)
            {
                tbl_patient.Rows.Add(dr.ItemArray);
            }


            HomePage.SetPage(2);

        }

        private void lbl_receptionist_Click(object sender, EventArgs e)
        {
            
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.Black;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.DarkGray;

            indicator.Location = new Point(168, 218);

            loadReceptionistTable();

            foreach (DataRow dr in dtReceptionist.Rows)
            {
                tbl_receptionist.Rows.Add(dr.ItemArray);
            }


            HomePage.SetPage(3);

        }

        private void lbl_nurse_Click(object sender, EventArgs e)
        {
          
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.Black;
            lbl_department.ForeColor = Color.DarkGray;

            indicator.Location = new Point(168, 260);

            loadNurseTable();

            foreach (DataRow dr in dtNurse.Rows)
            {
                tbl_nurse.Rows.Add(dr.ItemArray);
            }


            HomePage.SetPage(4);

        }

        private void lbl_department_Click(object sender, EventArgs e)
        {
           
            lbl_dashboard.ForeColor = Color.DarkGray;
            lbl_doctors.ForeColor = Color.DarkGray;
            lbl_patients.ForeColor = Color.DarkGray;
            lbl_receptionist.ForeColor = Color.DarkGray;
            lbl_nurse.ForeColor = Color.DarkGray;
            lbl_department.ForeColor = Color.Black;

            indicator.Location = new Point(168, 302);

            HomePage.PageIndex=5;

            loadDepartmentTable();

            foreach (DataRow dr in dtDepartment.Rows)
            {
                tbl_department.Rows.Add(dr.ItemArray);
            }

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


              //  Image image = CProject.Properties.Resources.
               // Image image = Image.FromFile(rootFolder,@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");
             
               Image image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Icons/edit.png"));


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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\details.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\delete.png");
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

                DoctorForm doctorDetails = new DoctorForm(id,0);
                doctorDetails.Show();
                
            }

            //edit button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                DoctorForm doctorDetails = new DoctorForm(id,1);
                doctorDetails.Show();
                lbl_doctors_Click(sender, e);
                
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
                        lbl_doctors_Click(sender, e);

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


            DoctorForm doctorDetails = new DoctorForm("Add Doctor");
            doctorDetails.Show();
            
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            try
            {
                loadDoctorTable();

                var rows = dtDoctor.Select(string.Format("FirstName LIKE '%{0}%' ", txt_doctor_search.Text));
             

                foreach (DataRow dr in rows)
                {
                    tbl_doctors.Rows.Add(dr.ItemArray);
                }

                tbl_doctors.Refresh();


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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\details.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\delete.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                lbl_patients_Click(sender, e);


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
                lbl_patients_Click(sender, e);

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
                    SqlCommand sqlCommand = new SqlCommand("spDeletePatient", con);


                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@patientId", id);


                    sqlCommand.Connection = con;

                    try

                    {

                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Patient Deleted successfully");
                        lbl_patients_Click(sender, e);

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

        private void tbl_receptionist_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //the code below adds image to the buttons int the datagridview
            if (e.RowIndex < 0)
                return;

            //Edit Column image
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\details.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\delete.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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

            //details button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                ReceptionistForm receptionistDetails = new ReceptionistForm(id, 0);
                receptionistDetails.Show();
                lbl_receptionist_Click(sender, e);


            }

            //edit button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                ReceptionistForm receptionistEdit = new ReceptionistForm(id, 1);
                receptionistEdit.Show();
                lbl_receptionist_Click(sender, e);

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
                    SqlCommand sqlCommand = new SqlCommand("spDeleteReceptionist", con);


                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@receptionistId", id);


                    sqlCommand.Connection = con;

                    try

                    {

                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Receptionist Deleted successfully");
                        lbl_receptionist_Click(sender, e);

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

        private void tbl_nurse_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //the code below adds image to the buttons int the datagridview
            if (e.RowIndex < 0)
                return;

            //Edit Column image
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\details.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

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
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\delete.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;


            }
        }

        private void tbl_nurse_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                NurseForm NurseDetails = new NurseForm(id, 0);
                NurseDetails.Show();
                lbl_nurse_Click(sender, e);


            }

            //edit button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                NurseForm NurseEdit = new NurseForm(id, 1);
                NurseEdit.Show();
                lbl_nurse_Click(sender, e);

            }

            //delete button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 9 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Nurse", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    SqlConnection con = DBService.ConnectDb();
                    SqlCommand sqlCommand = new SqlCommand("spDeleteNurse", con);


                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@NurseId", id);


                    sqlCommand.Connection = con;

                    try

                    {

                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Nurse Deleted successfully");
                        lbl_nurse_Click(sender, e);

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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            PatientForm addPatient = new PatientForm("Add Patient");
            addPatient.Show();


        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            ReceptionistForm addReceptionist = new ReceptionistForm("Add Receptionist");
            addReceptionist.Show();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            NurseForm addNurse = new NurseForm("Add Nurse");
            addNurse.Show();
        }
        int depid;

        private void tbl_department_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            var senderGrid = (DataGridView)sender;

            
           
            //edit button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 2 &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //gets the id of the selected column
                int id;
                id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                depid = id;

                txt_departmentName.Text = (string)senderGrid.Rows[e.RowIndex].Cells[1].Value;
              

            }

            //delete button clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3 &&
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
                    SqlCommand sqlCommand = new SqlCommand("spDeleteDepartment", con);


                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@depId", id);


                    sqlCommand.Connection = con;

                    try

                    {

                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Department Deleted successfully");
                        lbl_patients_Click(sender, e);

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

        private void tbl_department_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //the code below adds image to the buttons int the datagridview
            if (e.RowIndex < 0)
                return;

            //Edit Column image
            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
          

            //delete column image
            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\delete.png");
                // Image image = Image.FromFile(@"C:\Users\Aymen\Desktop\Hilcoe\2nd Year\-C-Final-Project-4813f4dbd3ac6eb2f3097861f96e6a74483c5d6c\CProject\Icons\edit.png");

                var w = image.Width - 70;
                var h = image.Height - 70;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;


            }
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            addDepartment();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            txt_departmentName.Text = "";
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            editDepartment();
        }

        private void addDepartment()
        {
            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spAddDepartment", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@depName", txt_departmentName.Text.Trim());


            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Department Added successfully");

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

        private void editDepartment()
        {
            SqlConnection con = DBService.ConnectDb();
            SqlCommand sqlCommand = new SqlCommand("spEditDepartment", con);


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@depId", depid);
            sqlCommand.Parameters.AddWithValue("@depName", txt_departmentName.Text.Trim());


            sqlCommand.Connection = con;

            try

            {

                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Department Updated successfully");

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

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_doctor_search_TextChange(object sender, EventArgs e)
        {
            try
            {
                loadDoctorTable();

                var rows = dtDoctor.Select(string.Format("FirstName LIKE '%{0}%' ", txt_doctor_search.Text));


                foreach (DataRow dr in rows)
                {
                    tbl_doctors.Rows.Add(dr.ItemArray);
                }

                tbl_doctors.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
