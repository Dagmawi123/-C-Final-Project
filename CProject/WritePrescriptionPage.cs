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
    public partial class WritePrescriptionPage : Form
    {
        public String docName { get; set; }

        public WritePrescriptionPage()
        {
            InitializeComponent();
        }

        public WritePrescriptionPage(String name)
        {
            InitializeComponent();
            docName = name;//select id of the doctor based on this
        }

        private void WritePrescriptionPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int medId;
                int docId;
                String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
                SqlConnection s = new SqlConnection(ConString);
                SqlCommand cmd1 = new SqlCommand("Select MedicineId from Medicine where MedicineName='" + tb_mname.Text + "'",s);
                s.Open();
                medId = (int)cmd1.ExecuteScalar();
                if (medId > 0) { MessageBox.Show("Medicine id retrieved"); }
                SqlCommand cmd2 = new SqlCommand("Select doctorId from Doctor where username='" + docName + "'",s);
                docId = (int)cmd2.ExecuteScalar();
                if (docId > 0) { MessageBox.Show("DoctorId retrieved"); }

                String query = "Insert into Prescription values( "  + tb_ptId.Text +","+ docId +","+ medId + ",'" + tb_Dose.Text + "'," + "Default" +","+ 1 + ")";
                SqlCommand cmd = new SqlCommand(query,s);
                int y=cmd.ExecuteNonQuery();
                if (y > 0) { MessageBox.Show("Prescription saved!"); }
                s.Close(); }
            catch (SqlException sq) { MessageBox.Show(sq.Message); }
        }
    }
}
