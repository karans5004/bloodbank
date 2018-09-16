namespace bloodbank
{
    partial class Form5
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
            this.button2 = new System.Windows.Forms.Button();
            this.rPhno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rBgroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rHb = new System.Windows.Forms.TextBox();
            this.rPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 55);
            this.button2.TabIndex = 26;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rPhno
            // 
            this.rPhno.Location = new System.Drawing.Point(624, 489);
            this.rPhno.Name = "rPhno";
            this.rPhno.Size = new System.Drawing.Size(286, 22);
            this.rPhno.TabIndex = 24;
            this.rPhno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "PHONE_NO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rAddress
            // 
            this.rAddress.Location = new System.Drawing.Point(624, 441);
            this.rAddress.Name = "rAddress";
            this.rAddress.Size = new System.Drawing.Size(286, 22);
            this.rAddress.TabIndex = 22;
            this.rAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "ADDRESS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rBgroup
            // 
            this.rBgroup.FormattingEnabled = true;
            this.rBgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.rBgroup.Location = new System.Drawing.Point(624, 336);
            this.rBgroup.Name = "rBgroup";
            this.rBgroup.Size = new System.Drawing.Size(307, 24);
            this.rBgroup.TabIndex = 20;
            this.rBgroup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "BLOOD TYPE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rName
            // 
            this.rName.Location = new System.Drawing.Point(624, 268);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(286, 22);
            this.rName.TabIndex = 18;
            this.rName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "RECIEVER DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1184, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SUBMIT REQUEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rQuantity
            // 
            this.rQuantity.Location = new System.Drawing.Point(1302, 222);
            this.rQuantity.Name = "rQuantity";
            this.rQuantity.Size = new System.Drawing.Size(100, 22);
            this.rQuantity.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1083, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "REQUIRED UNITS";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(205, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // rId
            // 
            this.rId.FormattingEnabled = true;
            this.rId.Location = new System.Drawing.Point(624, 219);
            this.rId.Name = "rId";
            this.rId.Size = new System.Drawing.Size(121, 24);
            this.rId.TabIndex = 30;
            this.rId.SelectedIndexChanged += new System.EventHandler(this.rId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "HB";
            // 
            // rHb
            // 
            this.rHb.Location = new System.Drawing.Point(624, 392);
            this.rHb.Name = "rHb";
            this.rHb.Size = new System.Drawing.Size(286, 22);
            this.rHb.TabIndex = 32;
            // 
            // rPassword
            // 
            this.rPassword.Location = new System.Drawing.Point(624, 544);
            this.rPassword.Name = "rPassword";
            this.rPassword.Size = new System.Drawing.Size(286, 22);
            this.rPassword.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "PASSWORD";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1853, 914);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rPassword);
            this.Controls.Add(this.rQuantity);
            this.Controls.Add(this.rHb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rPhno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rBgroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rPhno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rBgroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox rId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rHb;
        private System.Windows.Forms.TextBox rPassword;
        private System.Windows.Forms.Label label11;
    }
}