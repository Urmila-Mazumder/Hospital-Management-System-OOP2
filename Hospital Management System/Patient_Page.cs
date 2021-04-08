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
    public partial class Patient_Page : Form
    {
        public Patient_Page()
        {
            InitializeComponent();
        }

        private void Show_User_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_User_Info U1 = new Show_User_Info();
            U1.Show();
        }

        private void Show_Doctor_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_Doctor_Info D1 = new Show_Doctor_Info();
            D1.Show();
        }

        private void Update_User_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_User_Info U2 = new Update_User_Info();
            U2.Show();
        }

        private void Show_Test_Info_Click(object sender, EventArgs e)
        {
            this.Close();
            Show_Test_Info T1 = new Show_Test_Info();
            T1.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Patient_Page_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            First_Page f1 = new First_Page();
            f1.Show();
        }


       

       
    }
}
