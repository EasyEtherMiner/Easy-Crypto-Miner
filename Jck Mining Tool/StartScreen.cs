using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Diagnostics;
using Jck_Mining_Tool.Properties;
using System.Management;
using ManagedWinapi;

namespace Jck_Mining_Tool
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
            label1.Hide();
            this.Text = "Jck Mining Tool";
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Owner != null)
            {
                base.OnLoad(e);
                this.Location = Owner.Location;
                this.Size = Owner.Size;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int _ram = 0;

            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("select AdapterRAM from Win32_VideoController");

            foreach (ManagementObject mo in searcher1.Get())
            {
                var ram = mo.Properties["AdapterRAM"].Value as UInt32?;

                if (ram.HasValue)
                {
                    _ram = (int)(ram / 1048576);
                    
                    if (_ram <= 2000)
                    {
                        KeyTextFld.Hide();
                        GenKeyBtn.Text = "Exit";
                        label1.Show();
                        LocationLbl.Hide();
                    }
                }
            }

            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_VideoController");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string name = Convert.ToString(queryObj["Name"]);
                    long ram = Convert.ToInt64(queryObj["AdapterRAM"]);
                    _ram = (int)(ram / 1048576);
                }

                if (_ram <= 2000)
                {
                    throw new ManagementException();
                }
            }
            catch (ManagementException)
            {
                KeyTextFld.Hide();
                GenKeyBtn.Text = "Exit";
                label1.Show();
                LocationLbl.Hide();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (GenKeyBtn.Text == "Exit")
            {
                Application.Exit();
            }
            if (string.IsNullOrWhiteSpace(KeyTextFld.Text))
            {
                DialogResult result = MessageBox.Show("If you do not enter a key this computer will mine solely for the developer, are you sure you want to continue?",
                    "No Key Detected!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    Settings.Default.Key = "0x2a156c6dd3bdf2a0c5b284b45b2396c053c2a63d";
                    Settings.Default.First = true;
                    Settings.Default.Save();

                    switchWindow();
                }  
            }
            else
            {
                Settings.Default.Key = KeyTextFld.Text;
                Settings.Default.First = true;
                Settings.Default.Save();

                switchWindow();
            }
        }
        private void switchWindow()
        {
            Debug.WriteLine(Settings.Default.Key);
            Mining form2 = new Mining();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

    }

}
