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
            connection.Open();
            string str = "update reciever set name='" + this.rName.Text + "',address='" + this.rAddress.Text + "',bGroup='" + this.rBgroup.Text + "',hb='" + this.rHb.Text + "',phone_no='" + this.rPhno.Text + "',password='" + this.rPassword.Text + "' where id=" + this.rId.Text;
            MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            connection.Close();
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
            // TODO: This line of code loads data into the 'bbDataSet1.requesters' table. You can move, or remove it, as needed.
            this.requestersTableAdapter1.Fill(this.bbDataSet1.requesters);
            // TODO: This line of code loads data into the 'bbDataSet3.requesters' table. You can move, or remove it, as needed.
            this.requestersTableAdapter.Fill(this.bbDataSet3.requesters);
            this.WindowState = FormWindowState.Maximized;
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
            this.rAmtRec.Text = dr[5].ToString();
            this.rPhno.Text = dr[6].ToString();
            this.rPassword.Text = dr[7].ToString();
            dr.Close();
            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string str = "insert into requesters values(" + this.rId.Text + ",'" + this.rBgroup.Text + "','" + this.rQuantity.Text + "')";

            string str1 = "select cost_per_unit from requests_recieved where Bgroup = '" + this.rBgroup.Text + "';";
            MessageBox.Show(str1);
            //MessageBox.Show(str);
            MySqlCommand cmd = new MySqlCommand(str, connection);
            MySqlCommand cmd1 = new MySqlCommand(str1, connection);
            cmd.ExecuteNonQuery();
            //cmd1.ExecuteNonQuery();
            MySqlDataReader dr = cmd1.ExecuteReader();
            dr.Read();
            string abc = dr[0].ToString();


            if (rBgroup.Text == "O-")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();


            }

            if (rBgroup.Text == "O+")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();
            }

            if (rBgroup.Text == "A-")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();
            }

            if (rBgroup.Text == "A+")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();
            }

            if (rBgroup.Text == "B-")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();
            }

            
            if(rBgroup.Text == "B+")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();
            }

            if (rBgroup.Text == "AB-")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();
            }

            if (rBgroup.Text == "AB+")
            {
                MessageBox.Show("Amount to pay = " + Int32.Parse(abc) * Int32.Parse(rQuantity.Text));

                MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                connection1.Open();
                int ab = Int32.Parse(abc);
                int abb = Int32.Parse(rQuantity.Text);
                int amt_rec = ab * abb;
                string amt_reci = amt_rec.ToString();
                //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                string s1 = "update reciever set total_amount_paid = total_amount_paid +" + amt_reci + " where id = '" + rId.Text + "';";
                MessageBox.Show(s1);
                MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                cmd2.ExecuteNonQuery();
                connection1.Close();
            }


            dr.Close();
            connection.Close();


            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

        private void rPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
