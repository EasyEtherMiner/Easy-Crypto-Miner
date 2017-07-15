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
using BespokeFusion;

namespace Jck_Mining_Tool
{
    public partial class Location : MaterialForm
    {
        public Location()
        {
            InitializeComponent();
            Text = "Jck Mining Tool";

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = "eth-us-east1.nanopool.org:9999";
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = "eth-us-west1.nanopool.org:9999";
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = "eth-eu1.nanopool.org:9999";
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = "eth-asia1.nanopool.org:9999";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (usEast.Checked || usWest.Checked || eu.Checked || asia.Checked)
            {
                Main Main = new Main();
                Main.Tag = this;
                Main.Show(this);
                Hide();
            }
            else
            {
                MaterialMessageBox.Show("Please select a server location", "No location selected");
            }
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
    }
}
