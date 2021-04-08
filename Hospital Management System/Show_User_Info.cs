using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Show_User_Info : Form
    {
        public Show_User_Info()
        {
            InitializeComponent();
        }


        private void bttn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient_Page p1 = new Patient_Page();
            p1.Show();
        }

     
    }
}
