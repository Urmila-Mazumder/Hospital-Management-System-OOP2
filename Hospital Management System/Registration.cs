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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void textFN_MouseClick(object sender, MouseEventArgs e)
        {
            textFN.Clear();
            textFN.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            First_Page f1 = new First_Page();
            f1.Show();
        }

        private void textLN_Click(object sender, EventArgs e)
        {
            textLN.Clear();
            textLN.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textAddress_Click(object sender, EventArgs e)
        {
            textAddress.Clear();
            textAddress.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textEmail_Click(object sender, EventArgs e)
        {
            textEmail.Clear();
            textEmail.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textPhone_Click(object sender, EventArgs e)
        {
            textPhone.Clear();
            textPhone.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            textPassword.Clear();
            textPassword.PasswordChar = '*';
            textPassword.ForeColor = Color.FromArgb(48, 184, 206);

            
        }

        private void textConfirmP_Click(object sender, EventArgs e)
        {
            textConfirmP.Clear();
            textConfirmP.PasswordChar = '*';
            textConfirmP.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void For_password1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (For_password1.Text == "Show")
            {
                textPassword.PasswordChar = '\0';
                For_password1.Text = "Hide";
            }
            else
            {
                textPassword.PasswordChar = '*';
                For_password1.Text = "Show";
            }
        }

        private void For_password2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (For_password2.Text == "Show")
            {
                textConfirmP.PasswordChar = '\0';
                For_password2.Text = "Hide";
            }
            else
            {
                textConfirmP.PasswordChar = '*';
                For_password2.Text = "Show";
            }
        }

        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            if (Accept.Checked == true)
            {
                Confirm_Reg.Enabled = true;
            }

            if (Accept.Checked == false)
            {
                Confirm_Reg.Enabled = false;
            }
        }

        private void Confirm_Reg_Click(object sender, EventArgs e)
        {
            string message = "Registration \nConfirmed";
            MessageBox.Show(message);
        }

    }
}
