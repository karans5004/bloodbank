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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size; 
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select id from reciever", connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rId.Items.Add(dr[0].ToString());

                }
                dr.Close();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void rId_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from reciever where id=" + this.rId.Text, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            this.rName.Text = dr[1].ToString();
            this.rBgroup.Text = dr[2].ToString();
            this.rHb.Text = dr[3].ToString();
            this.rAddress.Text = dr[4].ToString();
            this.rPhno.Text = dr[5].ToString();
            this.rPassword.Text = dr[6].ToString();
            dr.Close();
            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string str = "insert into requesters values(" + this.rId.Text + ",'" + this.rBgroup.Text + "','" + this.rQuantity.Text + "')";
            //MessageBox.Show(str);
            MySqlCommand cmd = new MySqlCommand(str, connection);
            cmd.ExecuteNonQuery();

            if (rBgroup.Text == "O-")
            {
                MessageBox.Show("Amount to pay = " + 1200 * Int32.Parse(rQuantity.Text));
            }

            if (rBgroup.Text == "O+")
            {
                MessageBox.Show("Amount to pay = " + 1000 * Int32.Parse(rQuantity.Text));
            }

            if (rBgroup.Text == "A-")
            {
                MessageBox.Show("Amount to pay = " + 700 * Int32.Parse(rQuantity.Text));
            }

            if (rBgroup.Text == "A+")
            {
                MessageBox.Show("Amount to pay = " + 600 * Int32.Parse(rQuantity.Text));
            }

            if (rBgroup.Text == "B-")
            {
                MessageBox.Show("Amount to pay = " + 600 * Int32.Parse(rQuantity.Text));
            }

            
            if(rBgroup.Text == "B+")
            {
            MessageBox.Show("Amount to pay = "+ 500* Int32.Parse(rQuantity.Text));
            }

            if (rBgroup.Text == "AB-")
            {
                MessageBox.Show("Amount to pay = " + 800 * Int32.Parse(rQuantity.Text));
            }

            if (rBgroup.Text == "AB+")
            {
                MessageBox.Show("Amount to pay = " + 700 * Int32.Parse(rQuantity.Text));
            }



            connection.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }
    }
}
