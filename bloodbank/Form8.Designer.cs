namespace bloodbank
{
    partial class Form8
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
            this.bbDataSet1 = new bloodbank.bbDataSet1();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTableAdapter = new bloodbank.bbDataSet1TableAdapters.donorTableAdapter();
            this.bbDataSet2 = new bloodbank.bbDataSet2();
            this.donorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.donorTableAdapter1 = new bloodbank.bbDataSet2TableAdapters.donorTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bbDataSet5 = new bloodbank.bbDataSet5();
            this.availablestockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.available_stockTableAdapter = new bloodbank.bbDataSet5TableAdapters.available_stockTableAdapter();
            this.bgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costperunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablestockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bbDataSet1
            // 
            this.bbDataSet1.DataSetName = "bbDataSet1";
            this.bbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorBindingSource
            // 
            this.donorBindingSource.DataMember = "donor";
            this.donorBindingSource.DataSource = this.bbDataSet1;
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // bbDataSet2
            // 
            this.bbDataSet2.DataSetName = "bbDataSet2";
            this.bbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorBindingSource1
            // 
            this.donorBindingSource1.DataMember = "donor";
            this.donorBindingSource1.DataSource = this.bbDataSet2;
            // 
            // donorTableAdapter1
            // 
            this.donorTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bgroupDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costperunitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.availablestockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(285, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bbDataSet5
            // 
            this.bbDataSet5.DataSetName = "bbDataSet5";
            this.bbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availablestockBindingSource
            // 
            this.availablestockBindingSource.DataMember = "available_stock";
            this.availablestockBindingSource.DataSource = this.bbDataSet5;
            // 
            // available_stockTableAdapter
            // 
            this.available_stockTableAdapter.ClearBeforeFill = true;
            // 
            // bgroupDataGridViewTextBoxColumn
            // 
            this.bgroupDataGridViewTextBoxColumn.DataPropertyName = "Bgroup";
            this.bgroupDataGridViewTextBoxColumn.HeaderText = "Bgroup";
            this.bgroupDataGridViewTextBoxColumn.Name = "bgroupDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // costperunitDataGridViewTextBoxColumn
            // 
            this.costperunitDataGridViewTextBoxColumn.DataPropertyName = "cost_per_unit";
            this.costperunitDataGridViewTextBoxColumn.HeaderText = "cost_per_unit";
            this.costperunitDataGridViewTextBoxColumn.Name = "costperunitDataGridViewTextBoxColumn";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 522);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablestockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bbDataSet1 bbDataSet1;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private bbDataSet1TableAdapters.donorTableAdapter donorTableAdapter;
        private bbDataSet2 bbDataSet2;
        private System.Windows.Forms.BindingSource donorBindingSource1;
        private bbDataSet2TableAdapters.donorTableAdapter donorTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bbDataSet5 bbDataSet5;
        private System.Windows.Forms.BindingSource availablestockBindingSource;
        private bbDataSet5TableAdapters.available_stockTableAdapter available_stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costperunitDataGridViewTextBoxColumn;
    }
}