namespace MainGame
{
    partial class RunTo
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
            this.runOKbtn = new System.Windows.Forms.Button();
            this.runCancelbtn = new System.Windows.Forms.Button();
            this.runGenlbl = new System.Windows.Forms.Label();
            this.runGennud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.runGennud)).BeginInit();
            this.SuspendLayout();
            // 
            // runOKbtn
            // 
            this.runOKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.runOKbtn.Location = new System.Drawing.Point(25, 94);
            this.runOKbtn.Name = "runOKbtn";
            this.runOKbtn.Size = new System.Drawing.Size(104, 30);
            this.runOKbtn.TabIndex = 0;
            this.runOKbtn.Text = "OK";
            this.runOKbtn.UseVisualStyleBackColor = true;
            // 
            // runCancelbtn
            // 
            this.runCancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.runCancelbtn.Location = new System.Drawing.Point(151, 94);
            this.runCancelbtn.Name = "runCancelbtn";
            this.runCancelbtn.Size = new System.Drawing.Size(97, 30);
            this.runCancelbtn.TabIndex = 1;
            this.runCancelbtn.Text = "Cancel";
            this.runCancelbtn.UseVisualStyleBackColor = true;
            // 
            // runGenlbl
            // 
            this.runGenlbl.AutoSize = true;
            this.runGenlbl.Location = new System.Drawing.Point(22, 45);
            this.runGenlbl.Name = "runGenlbl";
            this.runGenlbl.Size = new System.Drawing.Size(79, 17);
            this.runGenlbl.TabIndex = 2;
            this.runGenlbl.Text = "Generation";
            // 
            // runGennud
            // 
            this.runGennud.Location = new System.Drawing.Point(128, 43);
            this.runGennud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.runGennud.Name = "runGennud";
            this.runGennud.Size = new System.Drawing.Size(120, 22);
            this.runGennud.TabIndex = 3;
            // 
            // RunTo
            // 
            this.AcceptButton = this.runOKbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.runCancelbtn;
            this.ClientSize = new System.Drawing.Size(262, 142);
            this.Controls.Add(this.runGennud);
            this.Controls.Add(this.runGenlbl);
            this.Controls.Add(this.runCancelbtn);
            this.Controls.Add(this.runOKbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RunTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunTo";
            ((System.ComponentModel.ISupportInitialize)(this.runGennud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runOKbtn;
        private System.Windows.Forms.Button runCancelbtn;
        private System.Windows.Forms.Label runGenlbl;
        private System.Windows.Forms.NumericUpDown runGennud;
    }
}