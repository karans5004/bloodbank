namespace bloodbank
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rName = new System.Windows.Forms.TextBox();
            this.rCity = new System.Windows.Forms.TextBox();
            this.rBType = new System.Windows.Forms.ComboBox();
            this.rPhno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rHb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECIEVER DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "BLOOD TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CITY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "PHONE NO.";
            // 
            // rName
            // 
            this.rName.Location = new System.Drawing.Point(570, 147);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(100, 22);
            this.rName.TabIndex = 8;
            this.rName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rCity
            // 
            this.rCity.Location = new System.Drawing.Point(570, 317);
            this.rCity.Name = "rCity";
            this.rCity.Size = new System.Drawing.Size(100, 22);
            this.rCity.TabIndex = 10;
            // 
            // rBType
            // 
            this.rBType.FormattingEnabled = true;
            this.rBType.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.rBType.Location = new System.Drawing.Point(570, 199);
            this.rBType.Name = "rBType";
            this.rBType.Size = new System.Drawing.Size(121, 24);
            this.rBType.TabIndex = 11;
            this.rBType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rPhno
            // 
            this.rPhno.Location = new System.Drawing.Point(570, 375);
            this.rPhno.Name = "rPhno";
            this.rPhno.Size = new System.Drawing.Size(172, 22);
            this.rPhno.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rPassword
            // 
            this.rPassword.Location = new System.Drawing.Point(570, 436);
            this.rPassword.Name = "rPassword";
            this.rPassword.Size = new System.Drawing.Size(172, 22);
            this.rPassword.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "HB";
            // 
            // rHb
            // 
            this.rHb.Location = new System.Drawing.Point(570, 259);
            this.rHb.Name = "rHb";
            this.rHb.Size = new System.Drawing.Size(100, 22);
            this.rHb.TabIndex = 23;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1869, 921);
            this.Controls.Add(this.rHb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rPassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rPhno);
            this.Controls.Add(this.rBType);
            this.Controls.Add(this.rCity);
            this.Controls.Add(this.rName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form3";
            this.Text = "RECIEVER DETAILS";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rName;
        private System.Windows.Forms.TextBox rCity;
        private System.Windows.Forms.ComboBox rBType;
        private System.Windows.Forms.TextBox rPhno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rHb;
    }
}