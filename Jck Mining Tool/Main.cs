using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Management;
using System.Runtime.InteropServices;
using System.IO;

namespace Jck_Mining_Tool
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            gpuTimer.Start();
            MiningSettings.StartMining();
            Properties.Settings.Default.Third = true;
            Properties.Settings.Default.Save();

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
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Variables.JCKMiner.Kill();
            }
            catch { }
            try
            {
                Variables.Miner.Kill();
            }
            catch { }
            try
            {
                Variables.AdvancedMiner.Kill();
            }
            catch { }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            MiningSettings form2 = new MiningSettings();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void gpuTimer_Tick(object sender, EventArgs e)
        {
          if (MiningLbl.Text == "Mining")
            {
                MiningLbl.Text = "Mining.";
            }
            else if (MiningLbl.Text == "Mining.")
            {
                MiningLbl.Text = "Mining..";
            }
            else if (MiningLbl.Text == "Mining..")
            {
                MiningLbl.Text = "Mining...";
            }
            else if (MiningLbl.Text == "Mining...")
            {
                MiningLbl.Text = "Mining";
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
             string Balance = "https://eth.nanopool.org/account/" + Properties.Settings.Default.Key;
            Process.Start(Balance);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0x2a156c6dd3bdf2a0c5b284b45b2396c053c2a63d");
            MessageBox.Show("Wallet Key copied to clipboard.", "Thank you for conisdering to donate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    public class Variables
    {
        public static Process Miner = new Process();
        public static Process AdvancedMiner = new Process();
        public static Process JCKMiner = new Process();
        public static bool Enabled = Properties.Settings.Default.Startup;
        public static string Location = Properties.Settings.Default.Location;
        public static string Key = Properties.Settings.Default.Key;
        public static string WkrName = Properties.Settings.Default.WkrName;
    }
}
