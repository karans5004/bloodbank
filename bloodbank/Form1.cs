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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 childForm = new Form7();
           childForm.MdiParent = this;
            childForm.Text = "New Client";
            childForm.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           //DoRegForm.Size = new System.Drawing.Size(100%);
            Form2 DoRegForm = new Form2();
            DoRegForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                panel1.Visible = true;
                if (comboBox1.Text == "DONOR")
                {
                    try
                    {

                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand("select id from donor", connection);
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

                if (comboBox1.Text == "RECIEVER")
                {
                    try
                    {

                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand("select id from reciever", connection);
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
          /*  else if (comboBox1.SelectedIndex == 1)
            {
                panel2.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                panel3.Visible = true;
            }*/
        
    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
             if(comboBox1.Text == "DONOR")
            {
                MySqlCommand cmd = new MySqlCommand("select password from donor where id=" + this.dId.Text, connection);
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string abc = dr[0].ToString();
                if (dPassword.Text == abc)
                {
                    Form4 DoDetails = new Form4();
                    DoDetails.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
                connection.Close();
            }
             else if (comboBox1.Text == "RECIEVER")
             {
                 MySqlCommand cmd = new MySqlCommand("select password from reciever where id=" + this.dId.Text, connection);
                 connection.Open();
                 MySqlDataReader dr = cmd.ExecuteReader();
                 dr.Read();
                 string abc = dr[0].ToString();
                 if (dPassword.Text == abc)
                 {
                     Form5 ReDetails = new Form5();
                     
                     ReDetails.Show();

                 }
                 else
                 {
                     MessageBox.Show("Invalid Password");
                 }
                 connection.Close();
             }
            
            
        
               
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //panel2.Visible = false;
            //panel3.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 bInventory = new Form6();

            bInventory.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            


            
        }

        private void dId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dPassword_TextChanged(object sender, EventArgs e)
        {

            dPassword.PasswordChar = '*';
        }
        



        
    }
}
