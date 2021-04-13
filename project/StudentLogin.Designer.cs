namespace FinalProject
{
    partial class StudentLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            this.newpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonremoveaccout = new System.Windows.Forms.Button();
            this.buttonstudentresult = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttonstudentdetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(327, 285);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(100, 22);
            this.newpass.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonremoveaccout
            // 
            this.buttonremoveaccout.Location = new System.Drawing.Point(181, 313);
            this.buttonremoveaccout.Name = "buttonremoveaccout";
            this.buttonremoveaccout.Size = new System.Drawing.Size(256, 50);
            this.buttonremoveaccout.TabIndex = 17;
            this.buttonremoveaccout.Text = "Change Password";
            this.buttonremoveaccout.UseVisualStyleBackColor = true;
            this.buttonremoveaccout.Click += new System.EventHandler(this.buttonremoveaccout_Click);
            // 
            // buttonstudentresult
            // 
            this.buttonstudentresult.Location = new System.Drawing.Point(327, 174);
            this.buttonstudentresult.Name = "buttonstudentresult";
            this.buttonstudentresult.Size = new System.Drawing.Size(256, 50);
            this.buttonstudentresult.TabIndex = 13;
            this.buttonstudentresult.Text = "Student Result";
            this.buttonstudentresult.UseVisualStyleBackColor = true;
            this.buttonstudentresult.Click += new System.EventHandler(this.buttonstudentresult_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.Location = new System.Drawing.Point(181, 369);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(256, 50);
            this.buttonlogout.TabIndex = 14;
            this.buttonlogout.Text = "Log Out";
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // buttonstudentdetails
            // 
            this.buttonstudentdetails.Location = new System.Drawing.Point(40, 174);
            this.buttonstudentdetails.Name = "buttonstudentdetails";
            this.buttonstudentdetails.Size = new System.Drawing.Size(256, 50);
            this.buttonstudentdetails.TabIndex = 15;
            this.buttonstudentdetails.Text = "Student Details";
            this.buttonstudentdetails.UseVisualStyleBackColor = true;
            this.buttonstudentdetails.Click += new System.EventHandler(this.buttonstudentdetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "New Password";
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonremoveaccout);
            this.Controls.Add(this.buttonstudentresult);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonstudentdetails);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonremoveaccout;
        private System.Windows.Forms.Button buttonstudentresult;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button buttonstudentdetails;
        private System.Windows.Forms.Label label1;
    }
}