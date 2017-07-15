using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BespokeFusion;
using System.IO;

namespace Jck_Mining_Tool
{
    public partial class Mining : MaterialForm
    {
        public Mining()
        {
                InitializeComponent();
                Text = "Jck Mining Tool";
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

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WorkerTextField.Text))
            {
                MessageBox.Show("Please enter a vaild name for your worker", "No Worker Name Detected");
            }
            else
            {
                Properties.Settings.Default.WkrName = WorkerTextField.Text;
                Properties.Settings.Default.Second = true;
                Properties.Settings.Default.Save();

                Location Main = new Location();
                Main.Tag = this;
                Main.Show(this);
                Hide();
            }
        }
    }
}
