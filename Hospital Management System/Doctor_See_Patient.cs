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
    public partial class Doctor_See_Patient : Form
    {
        public Doctor_See_Patient()
        {
            InitializeComponent();
        }

        private void textFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Test_Information_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Test_Info S1 = new Show_Test_Info();
            S1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor D1 = new Doctor();
            D1.Show();
        }

        private void Prescription_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prescription Pr = new Prescription();
            Pr.Show();
        }
    }
}
