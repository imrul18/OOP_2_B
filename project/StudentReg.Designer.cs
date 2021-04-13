namespace FinalProject
{
    partial class StudentReg
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
            this.st_id = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.passing_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // st_id
            // 
            this.st_id.Location = new System.Drawing.Point(301, 48);
            this.st_id.Name = "st_id";
            this.st_id.Size = new System.Drawing.Size(142, 22);
            this.st_id.TabIndex = 0;
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(301, 91);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(142, 22);
            this.sname.TabIndex = 1;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(301, 132);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(142, 22);
            this.fname.TabIndex = 2;
            this.fname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(301, 176);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(142, 22);
            this.mname.TabIndex = 3;
            // 
            // passing_year
            // 
            this.passing_year.Location = new System.Drawing.Point(301, 257);
            this.passing_year.Name = "passing_year";
            this.passing_year.Size = new System.Drawing.Size(142, 22);
            this.passing_year.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mother Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Passing Year";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(301, 215);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(142, 22);
            this.t_id.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class Teacher ID";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Location = new System.Drawing.Point(245, 300);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(102, 48);
            this.buttonsubmit.TabIndex = 6;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // StudentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passing_year);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.st_id);
            this.Name = "StudentReg";
            this.Text = "StudentReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox st_id;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox passing_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonsubmit;
    }
}