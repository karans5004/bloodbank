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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;




          /*  try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select cost_per_unit from available_stock", connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    apa.Text =dr[0].ToString();
                    ana.Text = dr[1].ToString();
                    bpa.Text = dr[2].ToString();
                    bna.Text = dr[3].ToString();
                    abpa.Text = dr[4].ToString();
                    abna.Text = dr[5].ToString();
                    opa.Text = dr[6].ToString();
                    ona.Text = dr[7].ToString();

                }
                dr.Close();




                MySqlCommand command = new MySqlCommand("select cost_per_unit from requests_recieved", connection);
                MySqlDataReader dr1 = command.ExecuteReader();
                while (dr1.Read())
                {
                    apr.Text = dr1[0].ToString();
                    anr.Text = dr1[1].ToString();
                    bpr.Text = dr1[2].ToString();
                    bnr.Text = dr1[3].ToString();
                    abpr.Text = dr1[4].ToString();
                    abnr.Text = dr1[5].ToString();
                    opr.Text = dr1[6].ToString();
                    onr.Text = dr1[7].ToString();

                }
                dr1.Close();
                connection.Close();




            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
          
            


            */

        }
           
    }
}
