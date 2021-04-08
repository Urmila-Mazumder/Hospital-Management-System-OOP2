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
    public partial class Update_User_Info : Form
    {
        public Update_User_Info()
        {
            InitializeComponent();
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

        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            if (Accept.Checked == true)
            {
                Confirm_Update.Enabled = true;
            }

            if (Accept.Checked == false)
            {
                Confirm_Update.Enabled = false;
            }
        }

        private void Confirm_Update_Click(object sender, EventArgs e)
        {
            string message = "Update \nConfirmed";
            MessageBox.Show(message);
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient_Page p1 = new Patient_Page();
            p1.Show();
        }
   
    }
}
