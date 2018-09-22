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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bbDataSet4.donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.bbDataSet4.donation);
            // TODO: This line of code loads data into the 'bbDataSet1.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.bbDataSet1.donor);
            this.WindowState = FormWindowState.Maximized;
            try
            {
                
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select id from donor",connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dId.Items.Add(dr[0].ToString());

                }
                dr.Close();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
          
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from donor where id=" + this.dId.Text, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            this.dName.Text = dr[1].ToString();
            this.dBGroup.Text = dr[2].ToString();
            this.dHb.Text = dr[3].ToString();
            this.dAddress.Text = dr[4].ToString();
            this.dAmtRec.Text = dr[5].ToString();
            this.dPhno.Text = dr[6].ToString();
            this.dPassword.Text = dr[7].ToString();
            dr.Close();
            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string str = "update donor set name='" + this.dName.Text + "',address='" + this.dAddress.Text + "',bGroup='" + this.dBGroup.Text + "',hb='" + this.dHb.Text + "',phone_no='" + this.dPhno.Text + "',password='" + this.dPassword.Text + "' where id=" + this.dId.Text;
            MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            connection.Close();
        }

        protected void DONATE_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";

                string str1 = "select cost_per_unit from available_stock where Bgroup = '" + this.dBGroup.Text + "';";
                MySqlCommand cmd1 = new MySqlCommand(str1, connection);

                MySqlCommand cmd = new MySqlCommand(str, connection);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();
                string abc = dr[0].ToString();



                if (dBGroup.Text == "O-")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }

                if (dBGroup.Text == "O+")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }

                if (dBGroup.Text == "A-")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }

                if (dBGroup.Text == "A+")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }

                if (dBGroup.Text == "B-")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }


                if (dBGroup.Text == "B+")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }

                if (dBGroup.Text == "AB-")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }

                if (dBGroup.Text == "AB+")
                {
                    MessageBox.Show("Amount credited to you = " + Int32.Parse(abc) * Int32.Parse(dQuantity.Text));
                    MySqlConnection connection1 = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
                    connection1.Open();
                    int ab = Int32.Parse(abc);
                    int abb = Int32.Parse(dQuantity.Text);
                    int amt_rec = ab * abb;
                    string amt_reci = amt_rec.ToString();
                    //string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
                    string s1 = "update donor set total_amount_recieved = total_amount_recieved +" + amt_reci + " where id = '" + dId.Text + "';";
                    MessageBox.Show(s1);
                    MySqlCommand cmd2 = new MySqlCommand(s1, connection1);
                    cmd2.ExecuteNonQuery();
                    connection1.Close();
                }


                dr.Close();
                connection.Close();
                
            }
            catch (MySqlException e1)
            {
                MessageBox.Show(""+e1);
            }

            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void dPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       
        
    }
}
