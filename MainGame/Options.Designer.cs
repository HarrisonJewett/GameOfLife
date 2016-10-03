namespace MainGame
{
    partial class Options
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
            this.optOKBtn = new System.Windows.Forms.Button();
            this.optCancelBtn = new System.Windows.Forms.Button();
            this.tbctrlMain = new System.Windows.Forms.TabControl();
            this.tbpgGeneral = new System.Windows.Forms.TabPage();
            this.tbpgView = new System.Windows.Forms.TabPage();
            this.tbpgAdvanced = new System.Windows.Forms.TabPage();
            this.lblTime = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.lblXAxis = new System.Windows.Forms.Label();
            this.nudXAxis = new System.Windows.Forms.NumericUpDown();
            this.lblYAxis = new System.Windows.Forms.Label();
            this.nudYAxis = new System.Windows.Forms.NumericUpDown();
            this.btnGrid = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.btnCellColor = new System.Windows.Forms.Button();
            this.lblCellColor = new System.Windows.Forms.Label();
            this.tbctrlMain.SuspendLayout();
            this.tbpgGeneral.SuspendLayout();
            this.tbpgView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYAxis)).BeginInit();
            this.SuspendLayout();
            // 
            // optOKBtn
            // 
            this.optOKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optOKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.optOKBtn.Location = new System.Drawing.Point(532, 404);
            this.optOKBtn.Name = "optOKBtn";
            this.optOKBtn.Size = new System.Drawing.Size(96, 34);
            this.optOKBtn.TabIndex = 0;
            this.optOKBtn.Text = "OK";
            this.optOKBtn.UseVisualStyleBackColor = true;
            // 
            // optCancelBtn
            // 
            this.optCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.optCancelBtn.Location = new System.Drawing.Point(634, 404);
            this.optCancelBtn.Name = "optCancelBtn";
            this.optCancelBtn.Size = new System.Drawing.Size(96, 34);
            this.optCancelBtn.TabIndex = 1;
            this.optCancelBtn.Text = "Cancel";
            this.optCancelBtn.UseVisualStyleBackColor = true;
            // 
            // tbctrlMain
            // 
            this.tbctrlMain.Controls.Add(this.tbpgGeneral);
            this.tbctrlMain.Controls.Add(this.tbpgView);
            this.tbctrlMain.Controls.Add(this.tbpgAdvanced);
            this.tbctrlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbctrlMain.Location = new System.Drawing.Point(0, 0);
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(742, 398);
            this.tbctrlMain.TabIndex = 2;
            // 
            // tbpgGeneral
            // 
            this.tbpgGeneral.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbpgGeneral.Controls.Add(this.nudYAxis);
            this.tbpgGeneral.Controls.Add(this.lblYAxis);
            this.tbpgGeneral.Controls.Add(this.nudXAxis);
            this.tbpgGeneral.Controls.Add(this.lblXAxis);
            this.tbpgGeneral.Controls.Add(this.nudTimer);
            this.tbpgGeneral.Controls.Add(this.lblTime);
            this.tbpgGeneral.Location = new System.Drawing.Point(4, 25);
            this.tbpgGeneral.Name = "tbpgGeneral";
            this.tbpgGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgGeneral.Size = new System.Drawing.Size(734, 369);
            this.tbpgGeneral.TabIndex = 0;
            this.tbpgGeneral.Text = "General";
            // 
            // tbpgView
            // 
            this.tbpgView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbpgView.Controls.Add(this.lblCellColor);
            this.tbpgView.Controls.Add(this.btnCellColor);
            this.tbpgView.Controls.Add(this.lblBackgroundColor);
            this.tbpgView.Controls.Add(this.btnBackgroundColor);
            this.tbpgView.Controls.Add(this.lblGrid);
            this.tbpgView.Controls.Add(this.btnGrid);
            this.tbpgView.Location = new System.Drawing.Point(4, 25);
            this.tbpgView.Name = "tbpgView";
            this.tbpgView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgView.Size = new System.Drawing.Size(734, 369);
            this.tbpgView.TabIndex = 1;
            this.tbpgView.Text = "View";
            // 
            // tbpgAdvanced
            // 
            this.tbpgAdvanced.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbpgAdvanced.Location = new System.Drawing.Point(4, 25);
            this.tbpgAdvanced.Name = "tbpgAdvanced";
            this.tbpgAdvanced.Size = new System.Drawing.Size(734, 369);
            this.tbpgAdvanced.TabIndex = 2;
            this.tbpgAdvanced.Text = "Advanced";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(206, 17);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time between generations (mil)";
            // 
            // nudTimer
            // 
            this.nudTimer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nudTimer.Location = new System.Drawing.Point(227, 30);
            this.nudTimer.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTimer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(120, 22);
            this.nudTimer.TabIndex = 1;
            this.nudTimer.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblXAxis
            // 
            this.lblXAxis.AutoSize = true;
            this.lblXAxis.Location = new System.Drawing.Point(3, 64);
            this.lblXAxis.Name = "lblXAxis";
            this.lblXAxis.Size = new System.Drawing.Size(152, 17);
            this.lblXAxis.TabIndex = 2;
            this.lblXAxis.Text = "Number of cells across";
            // 
            // nudXAxis
            // 
            this.nudXAxis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nudXAxis.Location = new System.Drawing.Point(227, 64);
            this.nudXAxis.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudXAxis.Name = "nudXAxis";
            this.nudXAxis.Size = new System.Drawing.Size(120, 22);
            this.nudXAxis.TabIndex = 3;
            this.nudXAxis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblYAxis
            // 
            this.lblYAxis.AutoSize = true;
            this.lblYAxis.Location = new System.Drawing.Point(3, 98);
            this.lblYAxis.Name = "lblYAxis";
            this.lblYAxis.Size = new System.Drawing.Size(143, 17);
            this.lblYAxis.TabIndex = 4;
            this.lblYAxis.Text = "Number of cells down";
            // 
            // nudYAxis
            // 
            this.nudYAxis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nudYAxis.Location = new System.Drawing.Point(227, 98);
            this.nudYAxis.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudYAxis.Name = "nudYAxis";
            this.nudYAxis.Size = new System.Drawing.Size(120, 22);
            this.nudYAxis.TabIndex = 5;
            this.nudYAxis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnGrid
            // 
            this.btnGrid.Location = new System.Drawing.Point(22, 22);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(31, 26);
            this.btnGrid.TabIndex = 0;
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(74, 31);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(110, 17);
            this.lblGrid.TabIndex = 1;
            this.lblGrid.Text = "Grid Lines Color";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(22, 64);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(31, 26);
            this.btnBackgroundColor.TabIndex = 2;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(74, 73);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(121, 17);
            this.lblBackgroundColor.TabIndex = 3;
            this.lblBackgroundColor.Text = "Background Color";
            // 
            // btnCellColor
            // 
            this.btnCellColor.Location = new System.Drawing.Point(22, 111);
            this.btnCellColor.Name = "btnCellColor";
            this.btnCellColor.Size = new System.Drawing.Size(31, 26);
            this.btnCellColor.TabIndex = 4;
            this.btnCellColor.UseVisualStyleBackColor = true;
            this.btnCellColor.Click += new System.EventHandler(this.btnCellColor_Click);
            // 
            // lblCellColor
            // 
            this.lblCellColor.AutoSize = true;
            this.lblCellColor.Location = new System.Drawing.Point(74, 120);
            this.lblCellColor.Name = "lblCellColor";
            this.lblCellColor.Size = new System.Drawing.Size(102, 17);
            this.lblCellColor.TabIndex = 5;
            this.lblCellColor.Text = "Alive Cell Color";
            // 
            // Options
            // 
            this.AcceptButton = this.optOKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.optCancelBtn;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.tbctrlMain);
            this.Controls.Add(this.optCancelBtn);
            this.Controls.Add(this.optOKBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.tbctrlMain.ResumeLayout(false);
            this.tbpgGeneral.ResumeLayout(false);
            this.tbpgGeneral.PerformLayout();
            this.tbpgView.ResumeLayout(false);
            this.tbpgView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYAxis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optOKBtn;
        private System.Windows.Forms.Button optCancelBtn;
        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.TabPage tbpgGeneral;
        private System.Windows.Forms.TabPage tbpgView;
        private System.Windows.Forms.NumericUpDown nudYAxis;
        private System.Windows.Forms.Label lblYAxis;
        private System.Windows.Forms.NumericUpDown nudXAxis;
        private System.Windows.Forms.Label lblXAxis;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TabPage tbpgAdvanced;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Label lblCellColor;
        private System.Windows.Forms.Button btnCellColor;
    }
}