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
    public partial class AdminLogin : Form
    {
        public string ID;
        public AdminLogin(string IDs)
        {
            InitializeComponent();
            ID = IDs;
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentReg(ID).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentDetails(ID).Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonteacherreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new teacherReg().Show();
        }

        private void buttonteacherdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            new teacherDetails(ID).Show();
        }

        private void buttonremoveaccout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new deactive().Show();
        }

        private void buttonstudentresult_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Result_Show(ID).Show();
        }
    }
}
