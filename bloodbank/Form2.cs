﻿using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bloodbank
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=karan@5004");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bbDataSet.donor' table. You can move, or remove it, as needed.
         //this.donorTableAdapter.Fill(this.bbDataSet.donor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO bb.donor(name,Bgroup,hb,address,phone_no,password) VALUES('" + dName.Text + "','" + dBType.Text + "','" + dHB.Text + "','" + dAddress.Text + "','" + dPhone_no.Text + "','" + dPassword.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery,connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA INSERTED");
                }
                else
                {
                    MessageBox.Show("DATA NOT INSERTED");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("my sql exception occured");
            }
            connection.Close();

        }
    }
}
