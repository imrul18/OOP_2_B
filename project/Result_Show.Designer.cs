namespace FinalProject
{
    partial class Result_Show
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.dataGridViewstudentdetails = new System.Windows.Forms.DataGridView();
            this.st_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(356, 21);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(83, 32);
            this.buttonsearch.TabIndex = 6;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(218, 26);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(132, 22);
            this.textsearch.TabIndex = 5;
            // 
            // dataGridViewstudentdetails
            // 
            this.dataGridViewstudentdetails.AllowUserToAddRows = false;
            this.dataGridViewstudentdetails.AllowUserToDeleteRows = false;
            this.dataGridViewstudentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudentdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.st_id,
            this.cname,
            this.t_id,
            this.Number,
            this.Grade});
            this.dataGridViewstudentdetails.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewstudentdetails.Name = "dataGridViewstudentdetails";
            this.dataGridViewstudentdetails.ReadOnly = true;
            this.dataGridViewstudentdetails.RowHeadersWidth = 51;
            this.dataGridViewstudentdetails.RowTemplate.Height = 24;
            this.dataGridViewstudentdetails.Size = new System.Drawing.Size(598, 344);
            this.dataGridViewstudentdetails.TabIndex = 4;
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
            // cname
            // 
            this.cname.DataPropertyName = "cname";
            this.cname.HeaderText = "Subject";
            this.cname.MinimumWidth = 6;
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Width = 125;
            // 
            // t_id
            // 
            this.t_id.DataPropertyName = "t_id";
            this.t_id.HeaderText = "Teacher ID";
            this.t_id.MinimumWidth = 6;
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            this.t_id.Width = 125;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "cresult";
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 125;
            // 
            // Result_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.dataGridViewstudentdetails);
            this.Name = "Result_Show";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.DataGridView dataGridViewstudentdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}