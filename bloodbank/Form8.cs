using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bloodbank
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bbDataSet5.available_stock' table. You can move, or remove it, as needed.
            this.available_stockTableAdapter.Fill(this.bbDataSet5.available_stock);
            // TODO: This line of code loads data into the 'bbDataSet2.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter1.Fill(this.bbDataSet2.donor);
            // TODO: This line of code loads data into the 'bbDataSet1.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.bbDataSet1.donor);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
