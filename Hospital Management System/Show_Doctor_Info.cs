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
    public partial class Show_Doctor_Info : Form
    {
        public Show_Doctor_Info()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Appoint1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint A1 = new Appoint();
            A1.Show();
        }

        private void Appoint2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint A2 = new Appoint();
            A2.Show();
        }

        private void Appoint3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint A3 = new Appoint();
            A3.Show();
        }

        private void Appoint4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint A4 = new Appoint();
            A4.Show();
        }

        private void Appoint5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint A5 = new Appoint();
            A5.Show();
        }
    }
}
