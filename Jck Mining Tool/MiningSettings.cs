using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Jck_Mining_Tool
{
    public partial class MiningSettings : MaterialForm
    {
        public MiningSettings()
        {
            InitializeComponent();
            Text = "Settings";
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            if (Properties.Settings.Default.Startup == true)
            {
                materialRaisedButton1.Text = "Disable";
            }
            else if (Properties.Settings.Default.Startup == false)
            {
                materialRaisedButton1.Text = "Enable";
            }

            if (Properties.Settings.Default.Advanced == true)
            {
                materialRaisedButton2.Text = "Disable";
            }
            else if (Properties.Settings.Default.Advanced == false)
            {
                materialRaisedButton2.Text = "Enable";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
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


        /////////////
        ///Startup///
        /////////////
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (materialRaisedButton1.Text == "Enable")
            {
                registryKey.SetValue("Jck Mining Tool", "C:\\Program Files (x86)\\Easy Ether Miner\\Jck Mining Tool.exe");
                registryKey.Close();
                Properties.Settings.Default.Startup = true;
                Properties.Settings.Default.Save();
                materialRaisedButton1.Text = "Disable";
            }
            else if (materialRaisedButton1.Text == "Disable")
            {
                registryKey.SetValue("Jck Mining Tool", "C:\\Program Files (x86)\\Easy Ether Miner\\Jck Mining Tool.exe_");
                registryKey.Close();
                Properties.Settings.Default.Startup = false;
                Properties.Settings.Default.Save();
                materialRaisedButton1.Text = "Enable";
            }

        }
        //////////////////
        ///show console///
        //////////////////
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            if (materialRaisedButton2.Text == "Enable")
            {
                DialogResult = MessageBox.Show("Do you want to start advanced mode? This will require the miner to restart.", "Restart in advanced mode?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.Advanced = true;
                    Properties.Settings.Default.Save();
                    materialRaisedButton2.Text = "Disable";
                    StartMining();
                }
            }
            else if (materialRaisedButton2.Text == "Disable")
            {
                DialogResult = MessageBox.Show("Do you want to exit advanced mode? This will require the miner to restart.", "Restart in Normal mode?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.Advanced = false;
                    Properties.Settings.Default.Save();
                    StartMining();
                    materialRaisedButton2.Text = "Enable";
                }

            }

        }

        /////////////////////
        ///Change Settings///
        /////////////////////
        private void materialRaisedButton3_Click(object sender, EventArgs e)
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

            Form1 form2 = new Form1();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        public static void StartMining()
        {
            try
            {
                Variables.JCKMiner.Kill();
            }catch{ }
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

            if (Properties.Settings.Default.Developer == true)
            {
                Variables.JCKMiner.StartInfo.Arguments = $"--farm-recheck 200 -G -S {Properties.Settings.Default.Location} -FS eth-eu2.nanopool.org:9999 -O 0x2a156c6dd3bdf2a0c5b284b45b2396c053c2a63d.{Properties.Settings.Default.WkrName}";
                Variables.JCKMiner.StartInfo.CreateNoWindow = true;
                Variables.JCKMiner.StartInfo.UseShellExecute = false;
                Variables.JCKMiner.StartInfo.FileName = @"C:\Program Files (x86)\Easy Ether Miner\ethminer.exe";
                Variables.JCKMiner.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Variables.JCKMiner.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Easy Ether Miner";
                Variables.JCKMiner.Start();
            }
            

            if (Properties.Settings.Default.Advanced == true)
            {
                Variables.AdvancedMiner.StartInfo.Arguments = $"--farm-recheck 200 -G -S {Properties.Settings.Default.Location} -FS eth-eu2.nanopool.org:9999 -O {Properties.Settings.Default.Key}.{Properties.Settings.Default.WkrName}";
                Variables.AdvancedMiner.StartInfo.FileName = "ethminer.exe";
                Variables.AdvancedMiner.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Easy Ether Miner";
                Variables.AdvancedMiner.Start();
            }else if (Properties.Settings.Default.Advanced == false)
            {
                Variables.Miner.StartInfo.Arguments = $"--farm-recheck 200 -G -S {Properties.Settings.Default.Location} -FS eth-eu2.nanopool.org:9999 -O {Properties.Settings.Default.Key}.{Properties.Settings.Default.WkrName}";
                Variables.Miner.StartInfo.CreateNoWindow = true;
                Variables.Miner.StartInfo.UseShellExecute = false;
                Variables.Miner.StartInfo.FileName = @"C:\Program Files (x86)\Easy Ether Miner\ethminer.exe";
                Variables.Miner.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Variables.Miner.Start();
            }
        }

        //////////
        ///Back///
        //////////

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

            Main Main = new Main();
            Main.Tag = this;
            Main.Show(this);
            Hide();
        }
        /////////////////////
        ///Disable Support///
        /////////////////////
        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (materialRaisedButton5.Text == "Disable")
            {
                Properties.Settings.Default.Developer = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("I Understand that you want to get the most out of your system, and I would greatly appreciate it you would consider donating to my ethereum wallet. You can do this on the main mining screen.", "Consider Donating?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartMining();
                materialRaisedButton5.Text = "Enable";
                
            }else if (materialRaisedButton5.Text == "Enable")
            {
                Properties.Settings.Default.Developer = true;
                Properties.Settings.Default.Save();
                materialRaisedButton5.Text = "Disable";
                StartMining();


            }

        }
    }
}
