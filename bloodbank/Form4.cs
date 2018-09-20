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
            this.dName.Text = dr[0].ToString();
            this.dBGroup.Text = dr[2].ToString();
            this.dHb.Text = dr[3].ToString();
            this.dAddress.Text = dr[4].ToString();
            this.dPhno.Text = dr[5].ToString();
            this.dPassword.Text = dr[6].ToString();
            dr.Close();
            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string str = "update donor set name='" + this.dName.Text + "',address='" + this.dAddress.Text + "',bGroup='" + this.dBGroup.Text + "',hb='" + this.dHb.Text + "',phone_no='" + this.dPhno.Text + "',password='" + this.dPassword.Text + "' where id=" + this.dId.Text;
            MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            connection.Close();
        }

        private void DONATE_Click(object sender, EventArgs e)
        {
            connection.Open();
            string str = "insert into donation values(" + this.dId.Text + ",'" + this.dBGroup.Text + "','" + this.dQuantity.Text + "')";
            MessageBox.Show(str);
            MySqlCommand cmd = new MySqlCommand(str, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            connection.Close();
        }
    }
}
