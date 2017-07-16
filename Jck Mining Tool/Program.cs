using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Jck_Mining_Tool
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

            ////Reset
            //Properties.Settings.Default.First = false;
            //Properties.Settings.Default.Second = false;
            //Properties.Settings.Default.Third = false;
            //Properties.Settings.Default.Startup = false;
            //Properties.Settings.Default.Advanced = false;
            //Properties.Settings.Default.Developer = true;

            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.First == false)
            {
                Application.Run(new Form1());
            } else if (Properties.Settings.Default.First == true && Properties.Settings.Default.Second == false)
            {
                Application.Run(new Mining());
            } else if (Properties.Settings.Default.First == true && Properties.Settings.Default.Second == true && Properties.Settings.Default.Third == false)
            {
                Application.Run(new Location());
            } else if (Properties.Settings.Default.Third == true)
            {
                Application.Run(new Main());
            }

        }
    }
}
