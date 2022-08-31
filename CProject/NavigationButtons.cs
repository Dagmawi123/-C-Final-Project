using System;
using System.Windows.Forms;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CProject
{
    public partial class NavigationButtons : UserControl
    {
        
        public NavigationButtons()
        {
            InitializeComponent();


            
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
          
                ParentForm.WindowState = FormWindowState.Minimized;
         
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
           
            if (ParentForm. WindowState == FormWindowState.Normal)
                ParentForm.WindowState = FormWindowState.Maximized;
            else if (ParentForm. WindowState == FormWindowState.Maximized)
                ParentForm.WindowState = FormWindowState.Normal;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void minimize_btn_MouseHover(object sender, EventArgs e)
        {
            minimize_btn.ZoomOut();
        }

        private void minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            minimize_btn.ZoomIn();
        }

        private void maximize_btn_MouseHover(object sender, EventArgs e)
        {
            maximize_btn.ZoomOut(); 
        }

        private void maximize_btn_MouseLeave(object sender, EventArgs e)
        {
            maximize_btn.ZoomIn();   
        }
    }
}
