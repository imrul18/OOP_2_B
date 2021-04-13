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
    public partial class StudentReg : Form
    {
        public string ID;
        public StudentReg(string IDs)
        {
            InitializeComponent();
            ID = IDs;
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string sql= "insert into student_info Values(" + this.st_id.Text + ", '" + this.sname.Text + "', '" + this.fname.Text + "', '" + this.mname.Text + "', " + this.t_id.Text + "," +this.passing_year.Text+ ")";
            string sql1= "insert into login Values(" + this.st_id.Text + ", 'pass','ACTIVE')";
            DataAccess.ExecuteUpdate(sql);
            DataAccess.ExecuteUpdate(sql1);
            this.Hide();
            new AdminLogin(ID).Show();
            MessageBox.Show("Registration Successfull!!");
        }
    }
}
