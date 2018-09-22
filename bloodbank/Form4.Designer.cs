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
            this.components = new System.ComponentModel.Container();
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
            this.label11 = new System.Windows.Forms.Label();
            this.dAmtRec = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bbDataSet1 = new bloodbank.bbDataSet1();
            this.donorTableAdapter = new bloodbank.bbDataSet1TableAdapters.donorTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.bbDataSet4 = new bloodbank.bbDataSet4();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationTableAdapter = new bloodbank.bbDataSet4TableAdapters.donationTableAdapter();
            this.donoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(789, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DONOR DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(61, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(61, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // dName
            // 
            this.dName.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dName.Location = new System.Drawing.Point(377, 264);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(311, 43);
            this.dName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(61, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "BLOOD TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(61, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "ADDRESS";
            // 
            // dAddress
            // 
            this.dAddress.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dAddress.Location = new System.Drawing.Point(377, 427);
            this.dAddress.Name = "dAddress";
            this.dAddress.Size = new System.Drawing.Size(311, 43);
            this.dAddress.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(61, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "PHONE_NO";
            // 
            // dPhno
            // 
            this.dPhno.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dPhno.Location = new System.Drawing.Point(377, 512);
            this.dPhno.Name = "dPhno";
            this.dPhno.Size = new System.Drawing.Size(311, 43);
            this.dPhno.TabIndex = 10;
            // 
            // dId
            // 
            this.dId.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dId.FormattingEnabled = true;
            this.dId.Location = new System.Drawing.Point(377, 185);
            this.dId.Name = "dId";
            this.dId.Size = new System.Drawing.Size(311, 44);
            this.dId.TabIndex = 15;
            this.dId.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dBGroup
            // 
            this.dBGroup.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
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
            this.dBGroup.Location = new System.Drawing.Point(377, 345);
            this.dBGroup.Name = "dBGroup";
            this.dBGroup.Size = new System.Drawing.Size(311, 44);
            this.dBGroup.TabIndex = 6;
            this.dBGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(61, 598);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 38);
            this.label10.TabIndex = 17;
            this.label10.Text = "PASSWORD";
            // 
            // dPassword
            // 
            this.dPassword.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dPassword.Location = new System.Drawing.Point(377, 593);
            this.dPassword.Name = "dPassword";
            this.dPassword.Size = new System.Drawing.Size(311, 43);
            this.dPassword.TabIndex = 18;
            this.dPassword.TextChanged += new System.EventHandler(this.dPassword_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(1305, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 38);
            this.label7.TabIndex = 20;
            this.label7.Text = "DONATE BLOOD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(1169, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "HB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(1169, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(437, 38);
            this.label9.TabIndex = 2;
            this.label9.Text = "QUANTITY TO DONATE";
            // 
            // dQuantity
            // 
            this.dQuantity.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dQuantity.Location = new System.Drawing.Point(1676, 313);
            this.dQuantity.Name = "dQuantity";
            this.dQuantity.Size = new System.Drawing.Size(100, 43);
            this.dQuantity.TabIndex = 3;
            // 
            // DONATE
            // 
            this.DONATE.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DONATE.Location = new System.Drawing.Point(1393, 405);
            this.DONATE.Name = "DONATE";
            this.DONATE.Size = new System.Drawing.Size(201, 46);
            this.DONATE.TabIndex = 4;
            this.DONATE.Text = "DONATE";
            this.DONATE.UseVisualStyleBackColor = true;
            this.DONATE.Click += new System.EventHandler(this.DONATE_Click);
            // 
            // dHb
            // 
            this.dHb.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dHb.Location = new System.Drawing.Point(1676, 231);
            this.dHb.Name = "dHb";
            this.dHb.Size = new System.Drawing.Size(100, 43);
            this.dHb.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(215, 753);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(32, 676);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(527, 38);
            this.label11.TabIndex = 21;
            this.label11.Text = "TOTAL AMOUNT RECIEVED";
            // 
            // dAmtRec
            // 
            this.dAmtRec.AutoSize = true;
            this.dAmtRec.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dAmtRec.Location = new System.Drawing.Point(620, 676);
            this.dAmtRec.Name = "dAmtRec";
            this.dAmtRec.Size = new System.Drawing.Size(0, 38);
            this.dAmtRec.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donoridDataGridViewTextBoxColumn,
            this.bGroupDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(796, 553);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 262);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.VirtualMode = true;
            // 
            // donorBindingSource
            // 
            this.donorBindingSource.DataMember = "donor";
            this.donorBindingSource.DataSource = this.bbDataSet1;
            // 
            // bbDataSet1
            // 
            this.bbDataSet1.DataSetName = "bbDataSet1";
            this.bbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1087, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 34);
            this.label12.TabIndex = 34;
            this.label12.Text = "RECENT DONATIONS";
            // 
            // bbDataSet4
            // 
            this.bbDataSet4.DataSetName = "bbDataSet4";
            this.bbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "donation";
            this.donationBindingSource.DataSource = this.bbDataSet4;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
            // 
            // donoridDataGridViewTextBoxColumn
            // 
            this.donoridDataGridViewTextBoxColumn.DataPropertyName = "donor_id";
            this.donoridDataGridViewTextBoxColumn.HeaderText = "donor_id";
            this.donoridDataGridViewTextBoxColumn.Name = "donoridDataGridViewTextBoxColumn";
            // 
            // bGroupDataGridViewTextBoxColumn
            // 
            this.bGroupDataGridViewTextBoxColumn.DataPropertyName = "bGroup";
            this.bGroupDataGridViewTextBoxColumn.HeaderText = "bGroup";
            this.bGroupDataGridViewTextBoxColumn.Name = "bGroupDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1867, 928);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dAmtRec);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DONATE);
            this.Controls.Add(this.dHb);
            this.Controls.Add(this.dQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dPassword);
            this.Controls.Add(this.label10);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dAmtRec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bbDataSet1 bbDataSet1;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private bbDataSet1TableAdapters.donorTableAdapter donorTableAdapter;
        private System.Windows.Forms.Label label12;
        private bbDataSet4 bbDataSet4;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private bbDataSet4TableAdapters.donationTableAdapter donationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}