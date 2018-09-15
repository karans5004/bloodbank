namespace bloodbank
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.dName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dPhno = new System.Windows.Forms.TextBox();
            this.dId = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dBGroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dQuantity = new System.Windows.Forms.TextBox();
            this.DONATE = new System.Windows.Forms.Button();
            this.dHb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DONOR DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // dName
            // 
            this.dName.Location = new System.Drawing.Point(295, 211);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(100, 22);
            this.dName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "BLOOD TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ADDRESS";
            // 
            // dAddress
            // 
            this.dAddress.Location = new System.Drawing.Point(295, 348);
            this.dAddress.Name = "dAddress";
            this.dAddress.Size = new System.Drawing.Size(100, 22);
            this.dAddress.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "PHONE_NO";
            // 
            // dPhno
            // 
            this.dPhno.Location = new System.Drawing.Point(295, 403);
            this.dPhno.Name = "dPhno";
            this.dPhno.Size = new System.Drawing.Size(100, 22);
            this.dPhno.TabIndex = 10;
            // 
            // dId
            // 
            this.dId.FormattingEnabled = true;
            this.dId.Location = new System.Drawing.Point(295, 159);
            this.dId.Name = "dId";
            this.dId.Size = new System.Drawing.Size(121, 24);
            this.dId.TabIndex = 15;
            this.dId.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(47, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dBGroup
            // 
            this.dBGroup.FormattingEnabled = true;
            this.dBGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.dBGroup.Location = new System.Drawing.Point(295, 279);
            this.dBGroup.Name = "dBGroup";
            this.dBGroup.Size = new System.Drawing.Size(121, 24);
            this.dBGroup.TabIndex = 6;
            this.dBGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "PASSWORD";
            // 
            // dPassword
            // 
            this.dPassword.Location = new System.Drawing.Point(295, 456);
            this.dPassword.Name = "dPassword";
            this.dPassword.Size = new System.Drawing.Size(100, 22);
            this.dPassword.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(770, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "DONATE BLOOD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(672, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "HB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "QUANTITY TO DONATE";
            // 
            // dQuantity
            // 
            this.dQuantity.Location = new System.Drawing.Point(884, 283);
            this.dQuantity.Name = "dQuantity";
            this.dQuantity.Size = new System.Drawing.Size(100, 22);
            this.dQuantity.TabIndex = 3;
            // 
            // DONATE
            // 
            this.DONATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONATE.Location = new System.Drawing.Point(784, 330);
            this.DONATE.Name = "DONATE";
            this.DONATE.Size = new System.Drawing.Size(140, 35);
            this.DONATE.TabIndex = 4;
            this.DONATE.Text = "DONATE";
            this.DONATE.UseVisualStyleBackColor = true;
            this.DONATE.Click += new System.EventHandler(this.DONATE_Click);
            // 
            // dHb
            // 
            this.dHb.Location = new System.Drawing.Point(884, 225);
            this.dHb.Name = "dHb";
            this.dHb.Size = new System.Drawing.Size(100, 22);
            this.dHb.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1156, 600);
            this.Controls.Add(this.DONATE);
            this.Controls.Add(this.dHb);
            this.Controls.Add(this.dQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dPhno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dBGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dPhno;
        private System.Windows.Forms.ComboBox dId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox dBGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dQuantity;
        private System.Windows.Forms.Button DONATE;
        private System.Windows.Forms.TextBox dHb;
        private System.Windows.Forms.Button button2;
    }
}