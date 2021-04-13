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
    public partial class StudentLogin : Form
    {
        public string ID;
        public StudentLogin(string IDs)
        {
            ID = IDs;
            InitializeComponent();
        }

        private void buttonstudentdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentDetails(ID).Show();
        }

        private void buttonstudentresult_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Result_Show(ID).Show();
        }

        private void buttonremoveaccout_Click(object sender, EventArgs e)
        {
            string sql = "update login set password='" + this.newpass.Text + "' where userID=" + ID;
            DataAccess.ExecuteUpdate(sql);
            MessageBox.Show("Password Updated!!");
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
