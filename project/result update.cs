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
    public partial class result_update : Form
    {
        public string ID;
        public result_update(String IDs)
        {
            ID = IDs;

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "update student_course set cresult=" + this.textBox2.Text + " where st_id=" + this.textBox1.Text + " and cname='"+ this.textBox3.Text +"'";
            DataAccess.ExecuteUpdate(sql);
            MessageBox.Show("Password Updated!!");
            this.Hide();
            new TeacherLogin(ID).Show();
        }
    }
}
