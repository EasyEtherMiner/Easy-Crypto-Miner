namespace Jck_Mining_Tool
{
    partial class Mining
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
            this.WorkerTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.NextBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WorkerTextField
            // 
            this.WorkerTextField.Depth = 0;
            this.WorkerTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerTextField.Hint = "";
            this.WorkerTextField.Location = new System.Drawing.Point(53, 218);
            this.WorkerTextField.MaxLength = 32767;
            this.WorkerTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkerTextField.Name = "WorkerTextField";
            this.WorkerTextField.PasswordChar = '\0';
            this.WorkerTextField.SelectedText = "";
            this.WorkerTextField.SelectionLength = 0;
            this.WorkerTextField.SelectionStart = 0;
            this.WorkerTextField.Size = new System.Drawing.Size(397, 23);
            this.WorkerTextField.TabIndex = 1;
            this.WorkerTextField.TabStop = false;
            this.WorkerTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(49, 184);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(140, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Enter Worker Name";
            // 
            // NextBtn
            // 
            this.NextBtn.AutoSize = true;
            this.NextBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NextBtn.Depth = 0;
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextBtn.Icon = null;
            this.NextBtn.Location = new System.Drawing.Point(0, 369);
            this.NextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Primary = true;
            this.NextBtn.Size = new System.Drawing.Size(505, 36);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Mining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.WorkerTextField);
            this.Name = "Mining";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField WorkerTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton NextBtn;
        private System.Windows.Forms.Timer timer1;
    }
}