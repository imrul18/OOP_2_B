namespace FinalProject
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.buttonstudentreg = new System.Windows.Forms.Button();
            this.buttonteacherreg = new System.Windows.Forms.Button();
            this.buttonteacherdetails = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttonstudentdetails = new System.Windows.Forms.Button();
            this.buttonstudentresult = new System.Windows.Forms.Button();
            this.buttonremoveaccout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonstudentreg
            // 
            this.buttonstudentreg.Location = new System.Drawing.Point(39, 147);
            this.buttonstudentreg.Name = "buttonstudentreg";
            this.buttonstudentreg.Size = new System.Drawing.Size(256, 50);
            this.buttonstudentreg.TabIndex = 0;
            this.buttonstudentreg.Text = "Create Student Account";
            this.buttonstudentreg.UseVisualStyleBackColor = true;
            this.buttonstudentreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonteacherreg
            // 
            this.buttonteacherreg.Location = new System.Drawing.Point(326, 147);
            this.buttonteacherreg.Name = "buttonteacherreg";
            this.buttonteacherreg.Size = new System.Drawing.Size(256, 50);
            this.buttonteacherreg.TabIndex = 0;
            this.buttonteacherreg.Text = "Create Teacher Account";
            this.buttonteacherreg.UseVisualStyleBackColor = true;
            this.buttonteacherreg.Click += new System.EventHandler(this.buttonteacherreg_Click);
            // 
            // buttonteacherdetails
            // 
            this.buttonteacherdetails.Location = new System.Drawing.Point(39, 292);
            this.buttonteacherdetails.Name = "buttonteacherdetails";
            this.buttonteacherdetails.Size = new System.Drawing.Size(256, 50);
            this.buttonteacherdetails.TabIndex = 0;
            this.buttonteacherdetails.Text = "Teacher Details";
            this.buttonteacherdetails.UseVisualStyleBackColor = true;
            this.buttonteacherdetails.Click += new System.EventHandler(this.buttonteacherdetails_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.Location = new System.Drawing.Point(180, 365);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(256, 50);
            this.buttonlogout.TabIndex = 0;
            this.buttonlogout.Text = "Log Out";
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // buttonstudentdetails
            // 
            this.buttonstudentdetails.Location = new System.Drawing.Point(39, 220);
            this.buttonstudentdetails.Name = "buttonstudentdetails";
            this.buttonstudentdetails.Size = new System.Drawing.Size(256, 50);
            this.buttonstudentdetails.TabIndex = 0;
            this.buttonstudentdetails.Text = "Student Details";
            this.buttonstudentdetails.UseVisualStyleBackColor = true;
            this.buttonstudentdetails.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonstudentresult
            // 
            this.buttonstudentresult.Location = new System.Drawing.Point(326, 220);
            this.buttonstudentresult.Name = "buttonstudentresult";
            this.buttonstudentresult.Size = new System.Drawing.Size(256, 50);
            this.buttonstudentresult.TabIndex = 0;
            this.buttonstudentresult.Text = "Student Result";
            this.buttonstudentresult.UseVisualStyleBackColor = true;
            this.buttonstudentresult.Click += new System.EventHandler(this.buttonstudentresult_Click);
            // 
            // buttonremoveaccout
            // 
            this.buttonremoveaccout.Location = new System.Drawing.Point(326, 292);
            this.buttonremoveaccout.Name = "buttonremoveaccout";
            this.buttonremoveaccout.Size = new System.Drawing.Size(256, 50);
            this.buttonremoveaccout.TabIndex = 1;
            this.buttonremoveaccout.Text = "Remove Account";
            this.buttonremoveaccout.UseVisualStyleBackColor = true;
            this.buttonremoveaccout.Click += new System.EventHandler(this.buttonremoveaccout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonremoveaccout);
            this.Controls.Add(this.buttonstudentresult);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonstudentdetails);
            this.Controls.Add(this.buttonteacherreg);
            this.Controls.Add(this.buttonteacherdetails);
            this.Controls.Add(this.buttonstudentreg);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonstudentreg;
        private System.Windows.Forms.Button buttonteacherreg;
        private System.Windows.Forms.Button buttonteacherdetails;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button buttonstudentdetails;
        private System.Windows.Forms.Button buttonstudentresult;
        private System.Windows.Forms.Button buttonremoveaccout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}