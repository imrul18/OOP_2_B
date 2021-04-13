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
    public partial class teacherReg : Form
    {
        public teacherReg()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string sql = "insert into teacher_info Values(" + this.t_id.Text + ", '" + this.tname.Text + "', '" + this.comboBoxcname.ToString()+"')";
            string sql1 = "insert into login Values(" + this.t_id.Text + ", 'pass','ACTIVE')";
            DataAccess.ExecuteUpdate(sql);
            DataAccess.ExecuteUpdate(sql1);
            this.Hide();
            new AdminLogin("999").Show();
            MessageBox.Show("Registration Successfull!!");
        }
    }
}
