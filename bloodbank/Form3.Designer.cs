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
            this.components = new System.ComponentModel.Container();
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
            this.bbDataSet3 = new bloodbank.bbDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bbDataSet4 = new bloodbank.bbDataSet4();
            this.recieverTableAdapter = new bloodbank.bbDataSet4TableAdapters.recieverTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(311, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER AS \r\n   RECIEVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(292, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "BLOOD TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(292, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "CITY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(292, 613);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(292, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "PHONE NO.";
            // 
            // rName
            // 
            this.rName.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.rName.Location = new System.Drawing.Point(502, 319);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(100, 30);
            this.rName.TabIndex = 8;
            this.rName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rCity
            // 
            this.rCity.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.rCity.Location = new System.Drawing.Point(502, 489);
            this.rCity.Name = "rCity";
            this.rCity.Size = new System.Drawing.Size(100, 30);
            this.rCity.TabIndex = 10;
            // 
            // rBType
            // 
            this.rBType.Font = new System.Drawing.Font("MV Boli", 8.25F);
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
            this.rBType.Location = new System.Drawing.Point(502, 371);
            this.rBType.Name = "rBType";
            this.rBType.Size = new System.Drawing.Size(121, 26);
            this.rBType.TabIndex = 11;
            this.rBType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rPhno
            // 
            this.rPhno.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.rPhno.Location = new System.Drawing.Point(502, 547);
            this.rPhno.Name = "rPhno";
            this.rPhno.Size = new System.Drawing.Size(172, 30);
            this.rPhno.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.button2.Location = new System.Drawing.Point(380, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rPassword
            // 
            this.rPassword.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.rPassword.Location = new System.Drawing.Point(502, 608);
            this.rPassword.Name = "rPassword";
            this.rPassword.Size = new System.Drawing.Size(172, 30);
            this.rPassword.TabIndex = 20;
            this.rPassword.TextChanged += new System.EventHandler(this.rPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "HB";
            // 
            // rHb
            // 
            this.rHb.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.rHb.Location = new System.Drawing.Point(502, 431);
            this.rHb.Name = "rHb";
            this.rHb.Size = new System.Drawing.Size(100, 30);
            this.rHb.TabIndex = 23;
            // 
            // bbDataSet3
            // 
            this.bbDataSet3.DataSetName = "bbDataSet3";
            this.bbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bgroupDataGridViewTextBoxColumn,
            this.hbDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.phonenoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recieverBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(796, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 368);
            this.dataGridView1.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // bgroupDataGridViewTextBoxColumn
            // 
            this.bgroupDataGridViewTextBoxColumn.DataPropertyName = "Bgroup";
            this.bgroupDataGridViewTextBoxColumn.HeaderText = "Bgroup";
            this.bgroupDataGridViewTextBoxColumn.Name = "bgroupDataGridViewTextBoxColumn";
            // 
            // hbDataGridViewTextBoxColumn
            // 
            this.hbDataGridViewTextBoxColumn.DataPropertyName = "hb";
            this.hbDataGridViewTextBoxColumn.HeaderText = "hb";
            this.hbDataGridViewTextBoxColumn.Name = "hbDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // phonenoDataGridViewTextBoxColumn
            // 
            this.phonenoDataGridViewTextBoxColumn.DataPropertyName = "phone_no";
            this.phonenoDataGridViewTextBoxColumn.HeaderText = "phone_no";
            this.phonenoDataGridViewTextBoxColumn.Name = "phonenoDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // recieverBindingSource
            // 
            this.recieverBindingSource.DataMember = "reciever";
            this.recieverBindingSource.DataSource = this.bbDataSet4;
            // 
            // bbDataSet4
            // 
            this.bbDataSet4.DataSetName = "bbDataSet4";
            this.bbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recieverTableAdapter
            // 
            this.recieverTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1050, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "REGISTERED RECIEVERS";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1869, 921);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form3";
            this.Text = "RECIEVER REGISTRATION";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet4)).EndInit();
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
        private bbDataSet3 bbDataSet3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bbDataSet4 bbDataSet4;
        private System.Windows.Forms.BindingSource recieverBindingSource;
        private bbDataSet4TableAdapters.recieverTableAdapter recieverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}