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
    public partial class teacherDetails : Form
    {
        public string ID;
        public teacherDetails(string IDs)
        {
            ID = IDs;
        
        InitializeComponent();
            string sql = "select * from teacher_info";


            this.dataGridViewstudentdetails.AutoGenerateColumns = false;
            this.dataGridViewstudentdetails.ScrollBars = ScrollBars.Both;

            DataTable dt = DataAccess.ExecuteQuery(sql);
            this.dataGridViewstudentdetails.AutoGenerateColumns = false;
            this.dataGridViewstudentdetails.DataSource = dt;
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from teacher_info where t_id=" + this.textsearch.Text;


            this.dataGridViewstudentdetails.AutoGenerateColumns = false;
            this.dataGridViewstudentdetails.ScrollBars = ScrollBars.Both;

            DataTable dt = DataAccess.ExecuteQuery(sql);
            this.dataGridViewstudentdetails.AutoGenerateColumns = false;
            this.dataGridViewstudentdetails.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (ID.Length == 3)
                new AdminLogin(ID).Show();
            else if (ID.Length == 7)
                new TeacherLogin(ID).Show();
           
        }
    }
}
