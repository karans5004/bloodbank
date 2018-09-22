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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.MdiParent = this;
            home.Show();
            
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.MdiParent = this;
            home.Show();
        }

        
            
       /* private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Form1();
                home.MdiParent = this;
                home.FormClosed += new FormClosedEventHandler(home_FormClosed);
                home.Show();
            }
            else
                home.Activate();
        }

        void home_FormClosed(object sender, FormClosedEventHandler e)
        {
            home = null;
            //throw new NotImplementedException();
        

        }*/

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.MdiParent = this;
            home.Show();
        }

        private void dONORREGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 DoRegForm = new Form2();
            DoRegForm.MdiParent = this;
            DoRegForm.Show();
        }

        private void rEQUESTBLOODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ReqRegForm = new Form3();
            ReqRegForm.MdiParent = this;
            ReqRegForm.Show();
        }

        private void bLOODINVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 bInventory = new Form6();
            bInventory.MdiParent = this;
            bInventory.Show();
        }
    }
}
