namespace MainGame
{
    partial class Seed
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
            this.lblSeed = new System.Windows.Forms.Label();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.btnRandomSeed = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(9, 20);
            this.lblSeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(35, 13);
            this.lblSeed.TabIndex = 0;
            this.lblSeed.Text = "Seed:";
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(65, 19);
            this.nudSeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSeed.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(125, 20);
            this.nudSeed.TabIndex = 1;
            this.nudSeed.Value = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            // 
            // btnRandomSeed
            // 
            this.btnRandomSeed.Location = new System.Drawing.Point(217, 15);
            this.btnRandomSeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRandomSeed.Name = "btnRandomSeed";
            this.btnRandomSeed.Size = new System.Drawing.Size(79, 25);
            this.btnRandomSeed.TabIndex = 2;
            this.btnRandomSeed.Text = "Randomize";
            this.btnRandomSeed.UseVisualStyleBackColor = true;
            this.btnRandomSeed.Click += new System.EventHandler(this.btnRandomSeed_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(11, 73);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(67, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(82, 73);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Seed
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(337, 106);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRandomSeed);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.lblSeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seed";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.Button btnRandomSeed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}