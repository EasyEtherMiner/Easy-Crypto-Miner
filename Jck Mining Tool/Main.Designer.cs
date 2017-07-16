namespace Jck_Mining_Tool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpuTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.MiningLbl = new System.Windows.Forms.Label();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // gpuTimer
            // 
            this.gpuTimer.Interval = 1000;
            this.gpuTimer.Tick += new System.EventHandler(this.gpuTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "It is recomended to keep this \r\nprogram running at all times.\r\n";
            // 
            // MiningLbl
            // 
            this.MiningLbl.AutoSize = true;
            this.MiningLbl.BackColor = System.Drawing.Color.Transparent;
            this.MiningLbl.Font = new System.Drawing.Font("Roboto", 50F);
            this.MiningLbl.Location = new System.Drawing.Point(127, 176);
            this.MiningLbl.Name = "MiningLbl";
            this.MiningLbl.Size = new System.Drawing.Size(237, 81);
            this.MiningLbl.TabIndex = 14;
            this.MiningLbl.Text = "Mining";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BackgroundImage = global::Jck_Mining_Tool.Properties.Resources.cog;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.ForeColor = System.Drawing.Color.Coral;
            this.SettingsBtn.Location = new System.Drawing.Point(448, 66);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(45, 42);
            this.SettingsBtn.TabIndex = 15;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(375, 360);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(118, 36);
            this.materialRaisedButton1.TabIndex = 19;
            this.materialRaisedButton1.Text = "View Balance";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(12, 360);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(74, 36);
            this.materialRaisedButton2.TabIndex = 20;
            this.materialRaisedButton2.Text = "Donate";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.MiningLbl);
            this.Controls.Add(this.label2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gpuTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MiningLbl;
        private System.Windows.Forms.Button SettingsBtn;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}