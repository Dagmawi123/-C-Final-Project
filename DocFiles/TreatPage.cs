using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace CProject
{
    class TreatPage : Form
    {
        public int patientID;
        public TreatPage(int pID) {
            InitializeComponent();
            patientID = pID;
        }
        private Button button1;
        public PatientInfo patientInfo1; 

        
    
        private void InitializeComponent()
        {
            this.patientInfo1 = new CProject.PatientInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientInfo1
            // 
            this.patientInfo1.Location = new System.Drawing.Point(0, 0);
            this.patientInfo1.Name = "patientInfo1";
            this.patientInfo1.Size = new System.Drawing.Size(286, 368);
            this.patientInfo1.Symptom = null;
            this.patientInfo1.TabIndex = 0;
            this.patientInfo1.Treat = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Treat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TreatPage
            // 
            this.ClientSize = new System.Drawing.Size(287, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientInfo1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            String ConString = "Server=DESKTOP-44OPTQE\\SQLEXPRESS;Database=HMS;Trusted_Connection=true";
            SqlConnection s = new SqlConnection(ConString);
            //s.Open();
            SqlCommand sc = new SqlCommand("[spTreat]",s);
sc.CommandType= CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@PID", patientID);
                        s.Open();
            sc.ExecuteNonQuery();
            MessageBox.Show("Keep on! Appointment is done.");
                

        }
    }
}
