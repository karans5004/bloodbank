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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bbDataSet3 = new bloodbank.bbDataSet3();
            this.donorTableAdapter1 = new bloodbank.bbDataSet3TableAdapters.donorTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER AS DONOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 7.8F);
            this.label2.Location = new System.Drawing.Point(311, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "BLOOD TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label6.Location = new System.Drawing.Point(311, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "PHONE NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label8.Location = new System.Drawing.Point(311, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "ADDRESS";
            // 
            // dName
            // 
            this.dName.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.dName.Location = new System.Drawing.Point(521, 296);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(233, 30);
            this.dName.TabIndex = 10;
            this.dName.TextChanged += new System.EventHandler(this.dName_TextChanged);
            // 
            // dBType
            // 
            this.dBType.Font = new System.Drawing.Font("MV Boli", 8.25F);
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
            this.dBType.Location = new System.Drawing.Point(521, 357);
            this.dBType.Name = "dBType";
            this.dBType.Size = new System.Drawing.Size(127, 26);
            this.dBType.TabIndex = 13;
            // 
            // dPhone_no
            // 
            this.dPhone_no.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.dPhone_no.Location = new System.Drawing.Point(521, 549);
            this.dPhone_no.Name = "dPhone_no";
            this.dPhone_no.Size = new System.Drawing.Size(216, 30);
            this.dPhone_no.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.button1.Location = new System.Drawing.Point(380, 701);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.button2.Location = new System.Drawing.Point(584, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dAddress
            // 
            this.dAddress.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.dAddress.Location = new System.Drawing.Point(521, 490);
            this.dAddress.Name = "dAddress";
            this.dAddress.Size = new System.Drawing.Size(127, 30);
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
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label4.Location = new System.Drawing.Point(311, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "HB";
            // 
            // dHB
            // 
            this.dHB.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.dHB.Location = new System.Drawing.Point(521, 425);
            this.dHB.Name = "dHB";
            this.dHB.Size = new System.Drawing.Size(100, 30);
            this.dHB.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.label3.Location = new System.Drawing.Point(311, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "SET PASSOWRD";
            // 
            // dPassword
            // 
            this.dPassword.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.dPassword.Location = new System.Drawing.Point(521, 607);
            this.dPassword.Name = "dPassword";
            this.dPassword.Size = new System.Drawing.Size(100, 30);
            this.dPassword.TabIndex = 29;
            this.dPassword.TextChanged += new System.EventHandler(this.dPassword_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.bgroupDataGridViewTextBoxColumn,
            this.hbDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phonenoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(824, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(988, 555);
            this.dataGridView1.TabIndex = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
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
            // donorBindingSource1
            // 
            this.donorBindingSource1.DataMember = "donor";
            this.donorBindingSource1.DataSource = this.bbDataSet3;
            // 
            // bbDataSet3
            // 
            this.bbDataSet3.DataSetName = "bbDataSet3";
            this.bbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorTableAdapter1
            // 
            this.donorTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Papyrus", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1225, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 50);
            this.label7.TabIndex = 31;
            this.label7.Text = "REGISTERED    DONORS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1866, 839);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet3)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private bbDataSet3 bbDataSet3;
        private System.Windows.Forms.BindingSource donorBindingSource1;
        private bbDataSet3TableAdapters.donorTableAdapter donorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
    }
}