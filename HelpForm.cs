using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProject
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
                this.Close();
          //  MessageBox.Show("Escape pressed!");
        
        }
    }
}
