using System;
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
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=karan@5004");
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO bb.reciever(name,Bgroup,hb,city,phone_no,password) VALUES('" + rName.Text + "','" + rBType.Text + "','" + rHb.Text + "','" + rCity.Text + "','" + rPhno.Text + "','" + rPassword.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
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

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }
    }
}
