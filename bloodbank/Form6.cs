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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bbDataSet7.requests_recieved' table. You can move, or remove it, as needed.
            this.requests_recievedTableAdapter.Fill(this.bbDataSet7.requests_recieved);
            // TODO: This line of code loads data into the 'bbDataSet6.available_stock' table. You can move, or remove it, as needed.
           
            this.available_stockTableAdapter.Fill(this.bbDataSet6.available_stock);
            this.WindowState = FormWindowState.Maximized;

            
            //--------------------Available stock quantity-------------------------------

            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand("select quantity from available_stock where Bgroup='A+';",connection);
            MySqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();
            this.aqap.Text = dr1[0].ToString();
            dr1.Close();
            //connection.Close();


            MySqlCommand cmd2 = new MySqlCommand("select quantity from available_stock where Bgroup='A-';", connection);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            this.aqan.Text = dr2[0].ToString();
            dr2.Close();
            //connection.Close();


            MySqlCommand cmd3 = new MySqlCommand("select quantity from available_stock where Bgroup='B+';", connection);
            MySqlDataReader dr3 = cmd3.ExecuteReader();
            dr3.Read();
            this.aqbp.Text = dr3[0].ToString();
            dr3.Close();
            //connection.Close();


            MySqlCommand cmd4 = new MySqlCommand("select quantity from available_stock where Bgroup='B-';", connection);
            MySqlDataReader dr4 = cmd4.ExecuteReader();
            dr4.Read();
            this.aqbn.Text = dr4[0].ToString();
            dr4.Close();
            //connection.Close();



            MySqlCommand cmd5 = new MySqlCommand("select quantity from available_stock where Bgroup='AB+';", connection);
            MySqlDataReader dr5 = cmd5.ExecuteReader();
            dr5.Read();
            this.aqabp.Text = dr5[0].ToString();
            dr5.Close();
            //connection.Close();


            MySqlCommand cmd6 = new MySqlCommand("select quantity from available_stock where Bgroup='AB-';", connection);
            MySqlDataReader dr6 = cmd6.ExecuteReader();
            dr6.Read();
            this.aqabn.Text = dr6[0].ToString();
            dr6.Close();
            //connection.Close();



            MySqlCommand cmd7 = new MySqlCommand("select quantity from available_stock where Bgroup='O+';", connection);
            MySqlDataReader dr7 = cmd7.ExecuteReader();
            dr7.Read();
            this.aqop.Text = dr7[0].ToString();
            dr7.Close();
  //          connection.Close();



            MySqlCommand cmd8 = new MySqlCommand("select quantity from available_stock where Bgroup='O-';", connection);
            MySqlDataReader dr8 = cmd8.ExecuteReader();
            dr8.Read();
            this.aqon.Text = dr8[0].ToString();
            dr8.Close();
            //connection.Close();

            //-----------------------requests recieved quantity---------------------------------

            MySqlCommand cmd9 = new MySqlCommand("select quantity from requests_recieved where Bgroup='A+';", connection);
            MySqlDataReader dr9 = cmd9.ExecuteReader();
            dr9.Read();
            this.rqap.Text = dr9[0].ToString();
            dr9.Close();
            //connection.Close();

            MySqlCommand cmd10 = new MySqlCommand("select quantity from requests_recieved where Bgroup='A-';", connection);
            MySqlDataReader dr10 = cmd10.ExecuteReader();
            dr10.Read();
            this.rqan.Text = dr10[0].ToString();
            dr10.Close();


            MySqlCommand cmd11 = new MySqlCommand("select quantity from requests_recieved where Bgroup='B+';", connection);
            MySqlDataReader dr11 = cmd11.ExecuteReader();
            dr11.Read();
            this.rqbp.Text = dr11[0].ToString();
            dr11.Close();


            MySqlCommand cmd12 = new MySqlCommand("select quantity from requests_recieved where Bgroup='B-';", connection);
            MySqlDataReader dr12 = cmd12.ExecuteReader();
            dr12.Read();
            this.rqbn.Text = dr12[0].ToString();
            dr12.Close();


            MySqlCommand cmd13 = new MySqlCommand("select quantity from requests_recieved where Bgroup='AB+';", connection);
            MySqlDataReader dr13 = cmd13.ExecuteReader();
            dr13.Read();
            this.rqabp.Text = dr13[0].ToString();
            dr13.Close();


            MySqlCommand cmd14 = new MySqlCommand("select quantity from requests_recieved where Bgroup='AB-';", connection);
            MySqlDataReader dr14 = cmd14.ExecuteReader();
            dr14.Read();
            this.rqabn.Text = dr14[0].ToString();
            dr14.Close();



            MySqlCommand cmd15 = new MySqlCommand("select quantity from requests_recieved where Bgroup='O+';", connection);
            MySqlDataReader dr15= cmd15.ExecuteReader();
            dr15.Read();
            this.rqop.Text = dr15[0].ToString();
            dr15.Close();



            MySqlCommand cmd16 = new MySqlCommand("select quantity from requests_recieved where Bgroup='O-';", connection);
            MySqlDataReader dr16 = cmd16.ExecuteReader();
            dr16.Read();
            this.rqon.Text = dr16[0].ToString();
            dr16.Close();
            connection.Close();



            //---------------------cost_per_unit from available stock--------------------


            connection.Open();
            MySqlCommand cmd17 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='A+';", connection);
            MySqlDataReader dr17 = cmd17.ExecuteReader();
            dr17.Read();
            this.acap.Text = dr17[0].ToString();
            dr17.Close();
            //connection.Close();


            MySqlCommand cmd18 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='A-';", connection);
            MySqlDataReader dr18 = cmd18.ExecuteReader();
            dr18.Read();
            this.acan.Text = dr18[0].ToString();
            dr18.Close();
            //connection.Close();


            MySqlCommand cmd19 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='B+';", connection);
            MySqlDataReader dr19 = cmd19.ExecuteReader();
            dr19.Read();
            this.acbp.Text = dr19[0].ToString();
            dr19.Close();
            //connection.Close();


            MySqlCommand cmd20 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='B-';", connection);
            MySqlDataReader dr20 = cmd20.ExecuteReader();
            dr20.Read();
            this.acbn.Text = dr20[0].ToString();
            dr20.Close();
            //connection.Close();



            MySqlCommand cmd21 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='AB+';", connection);
            MySqlDataReader dr21 = cmd21.ExecuteReader();
            dr21.Read();
            this.acabp.Text = dr21[0].ToString();
            dr21.Close();
            //connection.Close();


            MySqlCommand cmd22 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='AB-';", connection);
            MySqlDataReader dr22 = cmd22.ExecuteReader();
            dr22.Read();
            this.acabn.Text = dr22[0].ToString();
            dr22.Close();
            //connection.Close();



            MySqlCommand cmd23 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='O+';", connection);
            MySqlDataReader dr23 = cmd22.ExecuteReader();
            dr23.Read();
            this.acop.Text = dr23[0].ToString();
            dr23.Close();
            //          connection.Close();



            MySqlCommand cmd24 = new MySqlCommand("select cost_per_unit from available_stock where Bgroup='O-';", connection);
            MySqlDataReader dr24 = cmd24.ExecuteReader();
            dr24.Read();
            this.acon.Text = dr24[0].ToString();
            dr24.Close();
            //connection.Close();


            //---------------------cost_per_unit from requests reciecved-------------------


            //connection.Open();
            MySqlCommand cmd25 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='A+';", connection);
            MySqlDataReader dr25 = cmd25.ExecuteReader();
            dr25.Read();
            this.apr.Text = dr25[0].ToString();
            dr25.Close();


            MySqlCommand cmd26 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='A-';", connection);
            MySqlDataReader dr26 = cmd26.ExecuteReader();
            dr26.Read();
            this.anr.Text = dr26[0].ToString();
            dr26.Close();


            MySqlCommand cmd27 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='B+';", connection);
            MySqlDataReader dr27 = cmd27.ExecuteReader();
            dr27.Read();
            this.bpr.Text = dr27[0].ToString();
            dr27.Close();


            MySqlCommand cmd28 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='B-';", connection);
            MySqlDataReader dr28 = cmd28.ExecuteReader();
            dr28.Read();
            this.bnr.Text = dr28[0].ToString();
            dr28.Close();


            MySqlCommand cmd29 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='AB+';", connection);
            MySqlDataReader dr29 = cmd29.ExecuteReader();
            dr29.Read();
            this.abpr.Text = dr29[0].ToString();
            dr29.Close();


            MySqlCommand cmd30 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='AB-';", connection);
            MySqlDataReader dr30 = cmd30.ExecuteReader();
            dr30.Read();
            this.abnr.Text = dr30[0].ToString();
            dr30.Close();



            MySqlCommand cmd31 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='O+';", connection);
            MySqlDataReader dr31 = cmd31.ExecuteReader();
            dr31.Read();
            this.opr.Text = dr31[0].ToString();
            dr31.Close();



            MySqlCommand cmd32 = new MySqlCommand("select cost_per_unit from requests_recieved where Bgroup='O-';", connection);
            MySqlDataReader dr32 = cmd32.ExecuteReader();
            dr32.Read();
            this.onr.Text = dr32[0].ToString();
            dr32.Close();
            //connection.Close();

            MySqlCommand cmd33 = new MySqlCommand("select sum(total_amount_paid) from reciever", connection);
            MySqlDataReader dr33 = cmd33.ExecuteReader();
            dr33.Read();
            string profit = dr33[0].ToString();
            this.TotAmtEarned.Text = profit; 
            dr33.Close();


            MySqlCommand cmd34 = new MySqlCommand("select sum(total_amount_recieved) from donor", connection);
            MySqlDataReader dr34 = cmd34.ExecuteReader();
            dr34.Read();
            string loss = dr34[0].ToString();
            this.TotAmtSpent.Text = loss;
            dr34.Close();



            if (Int32.Parse(profit) > Int32.Parse(loss))
            {
                this.status.Text = "PROFIT";
                int profitt = Int32.Parse(profit) - Int32.Parse(loss);
                this.StatusAmt.Text = profitt.ToString();
                this.status.BackColor = System.Drawing.Color.LightGreen ;
            }
            else if (Int32.Parse(profit) > Int32.Parse(loss))
            {
                this.status.Text = "NO PROFIT";
                this.StatusAmt.Text ="0";
                this.status.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                this.status.Text="LOSS";
                int losss = Int32.Parse(loss) - Int32.Parse(profit);
                this.StatusAmt.Text = losss.ToString();
                this.status.BackColor = System.Drawing.Color.Red;
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void acan_Click(object sender, EventArgs e)
        {

        }
           
    }
}
