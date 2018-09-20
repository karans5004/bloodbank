using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bloodbank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Form1 home = new Form1();
            home.Size = new System.Drawing.Size(500, 500);


            Form2 DoRegForm = new Form2();
            DoRegForm.Size = new System.Drawing.Size(500, 500);

            Form3 ReqRegForm = new Form3();
            ReqRegForm.Size = new System.Drawing.Size(500, 500);

            Form4 DoDetails = new Form4();
            DoDetails.Size = new System.Drawing.Size(500, 500);

            Form5 ReDetails = new Form5();
            ReDetails.Size = new System.Drawing.Size(500, 500);

            Form6 bInventory = new Form6();
            bInventory.Size = new System.Drawing.Size(500, 500);

            
            Application.Run(new Form8());
        }
    }
}
