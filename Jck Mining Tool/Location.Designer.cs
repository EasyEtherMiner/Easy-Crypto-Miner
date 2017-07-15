namespace Jck_Mining_Tool
{
    partial class Location
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
            this.usEast = new MaterialSkin.Controls.MaterialRadioButton();
            this.LocationLbl = new MaterialSkin.Controls.MaterialLabel();
            this.usWest = new MaterialSkin.Controls.MaterialRadioButton();
            this.eu = new MaterialSkin.Controls.MaterialRadioButton();
            this.asia = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // usEast
            // 
            this.usEast.AutoSize = true;
            this.usEast.Depth = 0;
            this.usEast.Font = new System.Drawing.Font("Roboto", 10F);
            this.usEast.Location = new System.Drawing.Point(58, 153);
            this.usEast.Margin = new System.Windows.Forms.Padding(0);
            this.usEast.MouseLocation = new System.Drawing.Point(-1, -1);
            this.usEast.MouseState = MaterialSkin.MouseState.HOVER;
            this.usEast.Name = "usEast";
            this.usEast.Ripple = true;
            this.usEast.Size = new System.Drawing.Size(143, 30);
            this.usEast.TabIndex = 0;
            this.usEast.TabStop = true;
            this.usEast.Text = "United States-East";
            this.usEast.UseVisualStyleBackColor = true;
            this.usEast.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Depth = 0;
            this.LocationLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.LocationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LocationLbl.Location = new System.Drawing.Point(54, 104);
            this.LocationLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(149, 19);
            this.LocationLbl.TabIndex = 1;
            this.LocationLbl.Text = "Select Your Location";
            // 
            // usWest
            // 
            this.usWest.AutoSize = true;
            this.usWest.Depth = 0;
            this.usWest.Font = new System.Drawing.Font("Roboto", 10F);
            this.usWest.Location = new System.Drawing.Point(58, 194);
            this.usWest.Margin = new System.Windows.Forms.Padding(0);
            this.usWest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.usWest.MouseState = MaterialSkin.MouseState.HOVER;
            this.usWest.Name = "usWest";
            this.usWest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usWest.Ripple = true;
            this.usWest.Size = new System.Drawing.Size(147, 30);
            this.usWest.TabIndex = 2;
            this.usWest.TabStop = true;
            this.usWest.Text = "United States-West";
            this.usWest.UseVisualStyleBackColor = true;
            this.usWest.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // eu
            // 
            this.eu.AutoSize = true;
            this.eu.Depth = 0;
            this.eu.Font = new System.Drawing.Font("Roboto", 10F);
            this.eu.Location = new System.Drawing.Point(58, 236);
            this.eu.Margin = new System.Windows.Forms.Padding(0);
            this.eu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.eu.MouseState = MaterialSkin.MouseState.HOVER;
            this.eu.Name = "eu";
            this.eu.Ripple = true;
            this.eu.Size = new System.Drawing.Size(72, 30);
            this.eu.TabIndex = 3;
            this.eu.TabStop = true;
            this.eu.Text = "Europe";
            this.eu.UseVisualStyleBackColor = true;
            this.eu.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // asia
            // 
            this.asia.AutoSize = true;
            this.asia.Depth = 0;
            this.asia.Font = new System.Drawing.Font("Roboto", 10F);
            this.asia.Location = new System.Drawing.Point(58, 275);
            this.asia.Margin = new System.Windows.Forms.Padding(0);
            this.asia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.asia.MouseState = MaterialSkin.MouseState.HOVER;
            this.asia.Name = "asia";
            this.asia.Ripple = true;
            this.asia.Size = new System.Drawing.Size(56, 30);
            this.asia.TabIndex = 4;
            this.asia.TabStop = true;
            this.asia.Text = "Asia";
            this.asia.UseVisualStyleBackColor = true;
            this.asia.CheckedChanged += new System.EventHandler(this.materialRadioButton4_CheckedChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(0, 369);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(505, 36);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Next";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.asia);
            this.Controls.Add(this.eu);
            this.Controls.Add(this.usWest);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.usEast);
            this.Name = "Location";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton usEast;
        private MaterialSkin.Controls.MaterialLabel LocationLbl;
        private MaterialSkin.Controls.MaterialRadioButton usWest;
        private MaterialSkin.Controls.MaterialRadioButton eu;
        private MaterialSkin.Controls.MaterialRadioButton asia;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}