using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from login where userid=" + this.textusername.Text + " and Password='" + this.textpassword.Text + "' and status= 'ACTIVE'";

            if (DataAccess.SingleVarification(sql))
            {
                this.Hide();
                if (this.textusername.Text.Length == 3)
                    new AdminLogin(this.textusername.Text).Show();
                else if (this.textusername.Text.Length == 7)
                    new TeacherLogin(this.textusername.Text).Show();
                else new StudentLogin(this.textusername.Text).Show();
            }
            else this.buttonlogin.Visible=false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
