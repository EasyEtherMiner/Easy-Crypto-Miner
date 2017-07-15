namespace Jck_Mining_Tool
{
    partial class Form1
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
            this.GenKeyBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LocationLbl = new MaterialSkin.Controls.MaterialLabel();
            this.KeyTextFld = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenKeyBtn
            // 
            this.GenKeyBtn.AutoSize = true;
            this.GenKeyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenKeyBtn.Depth = 0;
            this.GenKeyBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenKeyBtn.Icon = null;
            this.GenKeyBtn.Location = new System.Drawing.Point(0, 369);
            this.GenKeyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenKeyBtn.Name = "GenKeyBtn";
            this.GenKeyBtn.Primary = true;
            this.GenKeyBtn.Size = new System.Drawing.Size(505, 36);
            this.GenKeyBtn.TabIndex = 3;
            this.GenKeyBtn.Text = "Next";
            this.GenKeyBtn.UseVisualStyleBackColor = true;
            this.GenKeyBtn.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Depth = 0;
            this.LocationLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.LocationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LocationLbl.Location = new System.Drawing.Point(45, 183);
            this.LocationLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(173, 19);
            this.LocationLbl.TabIndex = 4;
            this.LocationLbl.Text = "Enter your Ethereum Key";
            // 
            // KeyTextFld
            // 
            this.KeyTextFld.Depth = 0;
            this.KeyTextFld.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextFld.Hint = "";
            this.KeyTextFld.Location = new System.Drawing.Point(49, 215);
            this.KeyTextFld.MaxLength = 32767;
            this.KeyTextFld.MouseState = MaterialSkin.MouseState.HOVER;
            this.KeyTextFld.Name = "KeyTextFld";
            this.KeyTextFld.PasswordChar = '\0';
            this.KeyTextFld.SelectedText = "";
            this.KeyTextFld.SelectionLength = 0;
            this.KeyTextFld.SelectionStart = 0;
            this.KeyTextFld.Size = new System.Drawing.Size(397, 23);
            this.KeyTextFld.TabIndex = 5;
            this.KeyTextFld.TabStop = false;
            this.KeyTextFld.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.Location = new System.Drawing.Point(3, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unfortunatly, You do not have enough vram or do not have a gpu installed.\r\n This " +
    "means that you cannot mine.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyTextFld);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.GenKeyBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton GenKeyBtn;
        private MaterialSkin.Controls.MaterialLabel LocationLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField KeyTextFld;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}

