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
    public partial class StudentDetails : Form
    {
        public string ID;
        public StudentDetails(string IDs)
        {
            InitializeComponent();
            ID = IDs;
            GroupSearch();
        }

        private void StudentDetails_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void GroupSearch()
        {
            string sql = "select * from student_info";


            this.dataGridViewstudentdetails.AutoGenerateColumns = false;
            this.dataGridViewstudentdetails.ScrollBars = ScrollBars.Both;

            DataTable dt = DataAccess.ExecuteQuery(sql);
            this.dataGridViewstudentdetails.AutoGenerateColumns = false;
            this.dataGridViewstudentdetails.DataSource = dt;
        }

        private void dataGridViewstudentdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from student_info where st_id="+this.textsearch.Text;


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
            else new StudentLogin(ID).Show();
        }
    }
}
