using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hospital_Management_System
{
    public partial class First_Page : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public First_Page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            User_ID.Clear();
            User_ID.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Pass.Clear();
            Pass.PasswordChar = '*';
            Pass.ForeColor = Color.FromArgb(48, 184, 206);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Reg(object sender, EventArgs e)
        {
            this.Hide();
            Registration f2 = new Registration();
            f2.Show();
        }

        private void SignIN_Click(object sender, EventArgs e)
        {
            string ID = User_ID.Text;
            string Password = Pass.Text;

            
                string q = "Select * from Patient where P_ID='" + ID + "' and Password='" + Password + "' ";
                objDBAccess.readDatathroughAdapter(q,dtUsers);

                //if (ID.Equals(" "))
                //{
                //    MessageBox.Show("Enter ID");
                //}

                if (dtUsers.Rows.Count == 1)
                {
                    objDBAccess.closeConn();

                    this.Hide();
                    Patient_Page p1 = new Patient_Page();
                    p1.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Craiteria");
                }
            
            

            //this.Hide();
            //Patient_Page p1 = new Patient_Page();
            //p1.Show();

            //this.Hide();
            //Doctor D1 = new Doctor();
            //D1.Show();

            //this.Hide();
            //Receptionist R1 = new Receptionist();
            //R1.Show();

        }

        private void For_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (For_password.Text == "Show")
            {
                Pass.PasswordChar = '\0';
                For_password.Text = "Hide";
            }
            else 
            {
                Pass.PasswordChar = '*';
                For_password.Text = "Show";
            }
        }

       
       
    }
}
