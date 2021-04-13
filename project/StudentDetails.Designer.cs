namespace FinalProject
{
    partial class StudentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewstudentdetails = new System.Windows.Forms.DataGridView();
            this.st_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passing_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewstudentdetails
            // 
            this.dataGridViewstudentdetails.AllowUserToAddRows = false;
            this.dataGridViewstudentdetails.AllowUserToDeleteRows = false;
            this.dataGridViewstudentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudentdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.st_id,
            this.sname,
            this.FName,
            this.mname,
            this.t_id,
            this.passing_year});
            this.dataGridViewstudentdetails.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewstudentdetails.Name = "dataGridViewstudentdetails";
            this.dataGridViewstudentdetails.ReadOnly = true;
            this.dataGridViewstudentdetails.RowHeadersWidth = 51;
            this.dataGridViewstudentdetails.RowTemplate.Height = 24;
            this.dataGridViewstudentdetails.Size = new System.Drawing.Size(598, 344);
            this.dataGridViewstudentdetails.TabIndex = 0;
            this.dataGridViewstudentdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudentdetails_CellContentClick);
            // 
            // st_id
            // 
            this.st_id.DataPropertyName = "st_id";
            this.st_id.HeaderText = "Student ID";
            this.st_id.MinimumWidth = 6;
            this.st_id.Name = "st_id";
            this.st_id.ReadOnly = true;
            this.st_id.Width = 125;
            // 
            // sname
            // 
            this.sname.DataPropertyName = "sname";
            this.sname.HeaderText = "Name";
            this.sname.MinimumWidth = 6;
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Width = 125;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "fname";
            this.FName.HeaderText = "Father Name";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Width = 125;
            // 
            // mname
            // 
            this.mname.DataPropertyName = "mname";
            this.mname.HeaderText = "Mother Name";
            this.mname.MinimumWidth = 6;
            this.mname.Name = "mname";
            this.mname.ReadOnly = true;
            this.mname.Width = 125;
            // 
            // t_id
            // 
            this.t_id.DataPropertyName = "t_id";
            this.t_id.HeaderText = "Instractor";
            this.t_id.MinimumWidth = 6;
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            this.t_id.Width = 125;
            // 
            // passing_year
            // 
            this.passing_year.DataPropertyName = "passing_year";
            this.passing_year.HeaderText = "Passing Year";
            this.passing_year.MinimumWidth = 6;
            this.passing_year.Name = "passing_year";
            this.passing_year.ReadOnly = true;
            this.passing_year.Width = 125;
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(218, 21);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(132, 22);
            this.textsearch.TabIndex = 1;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(356, 16);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(83, 32);
            this.buttonsearch.TabIndex = 2;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.dataGridViewstudentdetails);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentDetails_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewstudentdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn passing_year;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button button1;
    }
}