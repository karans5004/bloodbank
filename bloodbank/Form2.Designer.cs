namespace bloodbank
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dName = new System.Windows.Forms.TextBox();
            this.dBType = new System.Windows.Forms.ComboBox();
            this.dPhone_no = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dAddress = new System.Windows.Forms.TextBox();
            this.bbDataSet = new bloodbank.bbDataSet();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTableAdapter = new bloodbank.bbDataSetTableAdapters.donorTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dHB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dPassword = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(713, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER AS DONOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "BLOOD TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "PHONE NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "ADDRESS";
            // 
            // dName
            // 
            this.dName.Location = new System.Drawing.Point(497, 135);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(233, 22);
            this.dName.TabIndex = 10;
            // 
            // dBType
            // 
            this.dBType.FormattingEnabled = true;
            this.dBType.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.dBType.Location = new System.Drawing.Point(497, 196);
            this.dBType.Name = "dBType";
            this.dBType.Size = new System.Drawing.Size(127, 24);
            this.dBType.TabIndex = 13;
            // 
            // dPhone_no
            // 
            this.dPhone_no.Location = new System.Drawing.Point(497, 388);
            this.dPhone_no.Name = "dPhone_no";
            this.dPhone_no.Size = new System.Drawing.Size(216, 22);
            this.dPhone_no.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dAddress
            // 
            this.dAddress.Location = new System.Drawing.Point(497, 329);
            this.dAddress.Name = "dAddress";
            this.dAddress.Size = new System.Drawing.Size(127, 22);
            this.dAddress.TabIndex = 24;
            // 
            // bbDataSet
            // 
            this.bbDataSet.DataSetName = "bbDataSet";
            this.bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorBindingSource
            // 
            this.donorBindingSource.DataMember = "donor";
            this.donorBindingSource.DataSource = this.bbDataSet;
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "HB";
            // 
            // dHB
            // 
            this.dHB.Location = new System.Drawing.Point(497, 264);
            this.dHB.Name = "dHB";
            this.dHB.Size = new System.Drawing.Size(100, 22);
            this.dHB.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "SET PASSOWRD";
            // 
            // dPassword
            // 
            this.dPassword.Location = new System.Drawing.Point(497, 446);
            this.dPassword.Name = "dPassword";
            this.dPassword.Size = new System.Drawing.Size(100, 22);
            this.dPassword.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(86, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::bloodbank.Properties.Resources.Buddy_the_Blood_Drop_Hoxworth_Mascot_212x300;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1866, 839);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dHB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dPhone_no);
            this.Controls.Add(this.dBType);
            this.Controls.Add(this.dName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form2";
            this.Text = "DONOR REGISTRATION";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dName;
        private System.Windows.Forms.ComboBox dBType;
        private System.Windows.Forms.TextBox dPhone_no;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dAddress;
        private bbDataSet bbDataSet;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private bbDataSetTableAdapters.donorTableAdapter donorTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dHB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dPassword;
        private System.Windows.Forms.Button button3;
    }
}