﻿namespace bloodbank
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
            this.components = new System.ComponentModel.Container();
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
            this.rId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rHb = new System.Windows.Forms.TextBox();
            this.rPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.requestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bbDataSet3 = new bloodbank.bbDataSet3();
            this.requestersTableAdapter = new bloodbank.bbDataSet3TableAdapters.requestersTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.rAmtRec = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bbDataSet1 = new bloodbank.bbDataSet1();
            this.requestersTableAdapter1 = new bloodbank.bbDataSet1TableAdapters.requestersTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(247, 761);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 55);
            this.button2.TabIndex = 26;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rPhno
            // 
            this.rPhno.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rPhno.Location = new System.Drawing.Point(356, 551);
            this.rPhno.Name = "rPhno";
            this.rPhno.Size = new System.Drawing.Size(286, 43);
            this.rPhno.TabIndex = 24;
            this.rPhno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(82, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 38);
            this.label6.TabIndex = 23;
            this.label6.Text = "PHONE_NO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rAddress
            // 
            this.rAddress.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rAddress.Location = new System.Drawing.Point(356, 488);
            this.rAddress.Name = "rAddress";
            this.rAddress.Size = new System.Drawing.Size(286, 43);
            this.rAddress.TabIndex = 22;
            this.rAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(97, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 38);
            this.label5.TabIndex = 21;
            this.label5.Text = "ADDRESS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rBgroup
            // 
            this.rBgroup.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
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
            this.rBgroup.Location = new System.Drawing.Point(356, 361);
            this.rBgroup.Name = "rBgroup";
            this.rBgroup.Size = new System.Drawing.Size(307, 44);
            this.rBgroup.TabIndex = 20;
            this.rBgroup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(97, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 38);
            this.label4.TabIndex = 19;
            this.label4.Text = "BLOOD TYPE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rName
            // 
            this.rName.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rName.Location = new System.Drawing.Point(356, 297);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(286, 43);
            this.rName.TabIndex = 18;
            this.rName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(97, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(106, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(763, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "RECIEVER DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(989, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "SUBMIT REQUEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rQuantity
            // 
            this.rQuantity.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rQuantity.Location = new System.Drawing.Point(1202, 225);
            this.rQuantity.Name = "rQuantity";
            this.rQuantity.Size = new System.Drawing.Size(100, 43);
            this.rQuantity.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(778, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "REQUIRED UNITS";
            // 
            // rId
            // 
            this.rId.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rId.FormattingEnabled = true;
            this.rId.Location = new System.Drawing.Point(356, 233);
            this.rId.Name = "rId";
            this.rId.Size = new System.Drawing.Size(121, 44);
            this.rId.TabIndex = 30;
            this.rId.SelectedIndexChanged += new System.EventHandler(this.rId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(97, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 38);
            this.label7.TabIndex = 31;
            this.label7.Text = "HB";
            // 
            // rHb
            // 
            this.rHb.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rHb.Location = new System.Drawing.Point(356, 421);
            this.rHb.Name = "rHb";
            this.rHb.Size = new System.Drawing.Size(286, 43);
            this.rHb.TabIndex = 32;
            // 
            // rPassword
            // 
            this.rPassword.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rPassword.Location = new System.Drawing.Point(356, 614);
            this.rPassword.Name = "rPassword";
            this.rPassword.Size = new System.Drawing.Size(286, 43);
            this.rPassword.TabIndex = 33;
            this.rPassword.TextChanged += new System.EventHandler(this.rPassword_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(77, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 38);
            this.label11.TabIndex = 34;
            this.label11.Text = "PASSWORD";
            // 
            // requestersBindingSource
            // 
            this.requestersBindingSource.DataMember = "requesters";
            this.requestersBindingSource.DataSource = this.bbDataSet3;
            // 
            // bbDataSet3
            // 
            this.bbDataSet3.DataSetName = "bbDataSet3";
            this.bbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestersTableAdapter
            // 
            this.requestersTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(33, 703);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(549, 38);
            this.label9.TabIndex = 37;
            this.label9.Text = "TOTAL_AMOUNT_RECIEVED";
            // 
            // rAmtRec
            // 
            this.rAmtRec.AutoSize = true;
            this.rAmtRec.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rAmtRec.Location = new System.Drawing.Point(644, 703);
            this.rAmtRec.Name = "rAmtRec";
            this.rAmtRec.Size = new System.Drawing.Size(0, 38);
            this.rAmtRec.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestoridDataGridViewTextBoxColumn,
            this.bGroupDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestersBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(911, 525);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 145);
            this.dataGridView1.TabIndex = 39;
            // 
            // requestoridDataGridViewTextBoxColumn
            // 
            this.requestoridDataGridViewTextBoxColumn.DataPropertyName = "requestor_id";
            this.requestoridDataGridViewTextBoxColumn.HeaderText = "requestor_id";
            this.requestoridDataGridViewTextBoxColumn.Name = "requestoridDataGridViewTextBoxColumn";
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
            // requestersBindingSource1
            // 
            this.requestersBindingSource1.DataMember = "requesters";
            this.requestersBindingSource1.DataSource = this.bbDataSet1;
            // 
            // bbDataSet1
            // 
            this.bbDataSet1.DataSetName = "bbDataSet1";
            this.bbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestersTableAdapter1
            // 
            this.requestersTableAdapter1.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ravie", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1036, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(318, 27);
            this.label10.TabIndex = 40;
            this.label10.Text = "RECENT REQUESTERS";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1853, 914);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rAmtRec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rPassword);
            this.Controls.Add(this.rQuantity);
            this.Controls.Add(this.rHb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rId);
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
            this.Text = "RECIEVER DETAILS";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet1)).EndInit();
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
        private System.Windows.Forms.ComboBox rId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rHb;
        private System.Windows.Forms.TextBox rPassword;
        private System.Windows.Forms.Label label11;
        private bbDataSet3 bbDataSet3;
        private System.Windows.Forms.BindingSource requestersBindingSource;
        private bbDataSet3TableAdapters.requestersTableAdapter requestersTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rAmtRec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bbDataSet1 bbDataSet1;
        private System.Windows.Forms.BindingSource requestersBindingSource1;
        private bbDataSet1TableAdapters.requestersTableAdapter requestersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
    }
}