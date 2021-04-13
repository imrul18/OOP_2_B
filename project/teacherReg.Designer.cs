namespace FinalProject
{
    partial class teacherReg
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
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.comboBoxcname = new System.Windows.Forms.ComboBox();
            this.cname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Location = new System.Drawing.Point(341, 327);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(102, 48);
            this.buttonsubmit.TabIndex = 19;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(397, 118);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(142, 22);
            this.tname.TabIndex = 8;
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(397, 75);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(142, 22);
            this.t_id.TabIndex = 7;
            // 
            // comboBoxcname
            // 
            this.comboBoxcname.FormattingEnabled = true;
            this.comboBoxcname.Items.AddRange(new object[] {
            "BANGLA",
            "ENGLISH",
            "MATH"});
            this.comboBoxcname.Location = new System.Drawing.Point(397, 161);
            this.comboBoxcname.Name = "comboBoxcname";
            this.comboBoxcname.Size = new System.Drawing.Size(142, 24);
            this.comboBoxcname.TabIndex = 20;
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Location = new System.Drawing.Point(262, 161);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(96, 17);
            this.cname.TabIndex = 21;
            this.cname.Text = "Subject Name";
            // 
            // teacherReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.comboBoxcname);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.t_id);
            this.Name = "teacherReg";
            this.Text = "teacherReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.ComboBox comboBoxcname;
        private System.Windows.Forms.Label cname;
    }
}