using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CProject
{
    class TreatPage : Form
    {
        public int patientID;
        public TreatPage(int pID) {
            InitializeComponent();
            patientID = pID;
        }
        private Button btn_end;
        public PatientInfo patientInfo1;
        public String ConString = ConfigurationManager.ConnectionStrings["HMSConnectionString"].ConnectionString;



        private void InitializeComponent()
        {
            this.btn_end = new System.Windows.Forms.Button();
            this.patientInfo1 = new CProject.PatientInfo();
            this.SuspendLayout();
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(-1, 377);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(124, 23);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "End Appointment";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // patientInfo1
            // 
            this.patientInfo1.Location = new System.Drawing.Point(-1, 0);
            this.patientInfo1.Name = "patientInfo1";
            this.patientInfo1.Size = new System.Drawing.Size(279, 371);
            this.patientInfo1.Symptom = null;
            this.patientInfo1.TabIndex = 2;
            this.patientInfo1.Treat = null;
            this.patientInfo1.Load += new System.EventHandler(this.patientInfo1_Load);
            // 
            // TreatPage
            // 
            this.ClientSize = new System.Drawing.Size(272, 399);
            this.Controls.Add(this.patientInfo1);
            this.Controls.Add(this.btn_end);
            this.KeyPreview = true;
            this.Name = "TreatPage";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreatPage_KeyPress);
            this.ResumeLayout(false);

        }

        private void TreatPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            //String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
            SqlConnection s = new SqlConnection(ConString);
            //s.Open();
            SqlCommand sc = new SqlCommand("[spTreat]",s);
sc.CommandType= CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@PID", patientID);
                        s.Open();
            int c=sc.ExecuteNonQuery();
          if(c>0)
                MessageBox.Show("Keep on! Appointment is done.");
                

        }

        private void patientInfo1_Load(object sender, EventArgs e)
        {
                                                        
        }
    }
}
