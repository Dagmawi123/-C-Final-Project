using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProject
{
    public partial class PatientInfo : UserControl
    {
        private String myVar;

        public String Treat
        {
            get { return myVar; }
            set { myVar = value;
                tb_trt.Text = value;
            }
        }
        private String myVar2;

        public String Symptom
        {
            get { return myVar2; }
            set { myVar2 = value;
                tb_sym.Text = value;
            }
        }

    



        public PatientInfo(String trt,String Sym )
        {
            InitializeComponent();
            //tb_sym.Text = String.Join("",Sym);
            //tb_trt.Text = String.Join("", trt);
            tb_sym.Text = Sym;
            tb_trt.Text = trt;
            
        }
        public PatientInfo() { InitializeComponent(); }



        private void PatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void PatientInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Hide();
            }
        }
    }
}
