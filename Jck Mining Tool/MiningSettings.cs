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
            foreach (var process in Process.GetProcessesByName("Miner"))
            {
                process.Kill();
            }
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
            foreach (var process in Process.GetProcessesByName("Miner"))
            {
                process.Kill();
            }

            Form1 form2 = new Form1();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        public static void StartMining()
        {
                foreach (var process in Process.GetProcessesByName("Miner"))
                {
                    process.Kill();
                }

            if (Properties.Settings.Default.Developer == true)
            {
                Process JCKMiner = new Process();
                JCKMiner.StartInfo.Arguments = $"-epool {Properties.Settings.Default.Location} -ewal 0x2a156c6dd3bdf2a0c5b284b45b2396c053c2a63d.Jacquais -epsw x -mode 1 -ftime 10 -r 0";
                JCKMiner.StartInfo.CreateNoWindow = true;
                JCKMiner.StartInfo.UseShellExecute = false;
                JCKMiner.StartInfo.FileName = @"C:\Program Files (x86)\Easy Ether Miner\Miner.exe";
                JCKMiner.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                JCKMiner.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Easy Ether Miner";
                JCKMiner.Start();
            }
            

            if (Properties.Settings.Default.Advanced == true)
            {
                Process AdvancedMiner = new Process();
                AdvancedMiner.StartInfo.Arguments = $"-epool {Properties.Settings.Default.Location} -ewal {Properties.Settings.Default.Key}.{Properties.Settings.Default.WkrName} -epsw x -mode 1 -ftime 10 -r 0";
                AdvancedMiner.StartInfo.FileName = "Miner.exe";
                AdvancedMiner.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Easy Ether Miner";
                AdvancedMiner.Start();
            }else if (Properties.Settings.Default.Advanced == false)
            {
                Process Miner = new Process();
                Miner.StartInfo.Arguments = $"-epool {Properties.Settings.Default.Location} -ewal {Properties.Settings.Default.Key}.{Properties.Settings.Default.WkrName} -epsw x -mode 1 -ftime 10 -r 0";
                Miner.StartInfo.CreateNoWindow = true;
                Miner.StartInfo.UseShellExecute = false;
                Miner.StartInfo.FileName = @"C:\Program Files (x86)\Easy Ether Miner\Miner.exe";
                Miner.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Miner.Start();
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
                MessageBox.Show("I Understand that you want to get the most out of your system, and I would greatly appreciate it you would consider donating.", "Consider Donating?", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
