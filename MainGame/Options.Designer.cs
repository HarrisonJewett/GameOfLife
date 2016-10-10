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
            this.nudYAxis = new System.Windows.Forms.NumericUpDown();
            this.lblYAxis = new System.Windows.Forms.Label();
            this.nudXAxis = new System.Windows.Forms.NumericUpDown();
            this.lblXAxis = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbpgView = new System.Windows.Forms.TabPage();
            this.lblCellColor = new System.Windows.Forms.Label();
            this.btnCellColor = new System.Windows.Forms.Button();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            this.btnGrid = new System.Windows.Forms.Button();
            this.tbpgAdvanced = new System.Windows.Forms.TabPage();
            this.grpbxUniverseType = new System.Windows.Forms.GroupBox();
            this.rbtnFinite = new System.Windows.Forms.RadioButton();
            this.rbtnToroidal = new System.Windows.Forms.RadioButton();
            this.tbctrlMain.SuspendLayout();
            this.tbpgGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.tbpgView.SuspendLayout();
            this.tbpgAdvanced.SuspendLayout();
            this.grpbxUniverseType.SuspendLayout();
            this.SuspendLayout();
            // 
            // optOKBtn
            // 
            this.optOKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optOKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.optOKBtn.Location = new System.Drawing.Point(220, 262);
            this.optOKBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optOKBtn.Name = "optOKBtn";
            this.optOKBtn.Size = new System.Drawing.Size(72, 28);
            this.optOKBtn.TabIndex = 0;
            this.optOKBtn.Text = "OK";
            this.optOKBtn.UseVisualStyleBackColor = true;
            // 
            // optCancelBtn
            // 
            this.optCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.optCancelBtn.Location = new System.Drawing.Point(297, 262);
            this.optCancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optCancelBtn.Name = "optCancelBtn";
            this.optCancelBtn.Size = new System.Drawing.Size(72, 28);
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
            this.tbctrlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(377, 251);
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
            this.tbpgGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbpgGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpgGeneral.Name = "tbpgGeneral";
            this.tbpgGeneral.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpgGeneral.Size = new System.Drawing.Size(369, 225);
            this.tbpgGeneral.TabIndex = 0;
            this.tbpgGeneral.Text = "General";
            // 
            // nudYAxis
            // 
            this.nudYAxis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nudYAxis.Location = new System.Drawing.Point(170, 80);
            this.nudYAxis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudYAxis.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudYAxis.Name = "nudYAxis";
            this.nudYAxis.Size = new System.Drawing.Size(90, 20);
            this.nudYAxis.TabIndex = 5;
            this.nudYAxis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblYAxis
            // 
            this.lblYAxis.AutoSize = true;
            this.lblYAxis.Location = new System.Drawing.Point(2, 80);
            this.lblYAxis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYAxis.Name = "lblYAxis";
            this.lblYAxis.Size = new System.Drawing.Size(109, 13);
            this.lblYAxis.TabIndex = 4;
            this.lblYAxis.Text = "Number of cells down";
            // 
            // nudXAxis
            // 
            this.nudXAxis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nudXAxis.Location = new System.Drawing.Point(170, 52);
            this.nudXAxis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudXAxis.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudXAxis.Name = "nudXAxis";
            this.nudXAxis.Size = new System.Drawing.Size(90, 20);
            this.nudXAxis.TabIndex = 3;
            this.nudXAxis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblXAxis
            // 
            this.lblXAxis.AutoSize = true;
            this.lblXAxis.Location = new System.Drawing.Point(2, 52);
            this.lblXAxis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXAxis.Name = "lblXAxis";
            this.lblXAxis.Size = new System.Drawing.Size(114, 13);
            this.lblXAxis.TabIndex = 2;
            this.lblXAxis.Text = "Number of cells across";
            // 
            // nudTimer
            // 
            this.nudTimer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nudTimer.Location = new System.Drawing.Point(170, 24);
            this.nudTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.nudTimer.Size = new System.Drawing.Size(90, 20);
            this.nudTimer.TabIndex = 1;
            this.nudTimer.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(2, 24);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(153, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time between generations (mil)";
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
            this.tbpgView.Location = new System.Drawing.Point(4, 22);
            this.tbpgView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpgView.Name = "tbpgView";
            this.tbpgView.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpgView.Size = new System.Drawing.Size(495, 225);
            this.tbpgView.TabIndex = 1;
            this.tbpgView.Text = "View";
            // 
            // lblCellColor
            // 
            this.lblCellColor.AutoSize = true;
            this.lblCellColor.Location = new System.Drawing.Point(56, 98);
            this.lblCellColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCellColor.Name = "lblCellColor";
            this.lblCellColor.Size = new System.Drawing.Size(77, 13);
            this.lblCellColor.TabIndex = 5;
            this.lblCellColor.Text = "Alive Cell Color";
            // 
            // btnCellColor
            // 
            this.btnCellColor.Location = new System.Drawing.Point(16, 90);
            this.btnCellColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCellColor.Name = "btnCellColor";
            this.btnCellColor.Size = new System.Drawing.Size(23, 21);
            this.btnCellColor.TabIndex = 4;
            this.btnCellColor.UseVisualStyleBackColor = true;
            this.btnCellColor.Click += new System.EventHandler(this.btnCellColor_Click);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(56, 59);
            this.lblBackgroundColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(92, 13);
            this.lblBackgroundColor.TabIndex = 3;
            this.lblBackgroundColor.Text = "Background Color";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(16, 52);
            this.btnBackgroundColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(23, 21);
            this.btnBackgroundColor.TabIndex = 2;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(56, 25);
            this.lblGrid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(81, 13);
            this.lblGrid.TabIndex = 1;
            this.lblGrid.Text = "Grid Lines Color";
            // 
            // btnGrid
            // 
            this.btnGrid.Location = new System.Drawing.Point(16, 18);
            this.btnGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(23, 21);
            this.btnGrid.TabIndex = 0;
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpgAdvanced
            // 
            this.tbpgAdvanced.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbpgAdvanced.Controls.Add(this.grpbxUniverseType);
            this.tbpgAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tbpgAdvanced.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpgAdvanced.Name = "tbpgAdvanced";
            this.tbpgAdvanced.Size = new System.Drawing.Size(369, 225);
            this.tbpgAdvanced.TabIndex = 2;
            this.tbpgAdvanced.Text = "Advanced";
            // 
            // grpbxUniverseType
            // 
            this.grpbxUniverseType.Controls.Add(this.rbtnToroidal);
            this.grpbxUniverseType.Controls.Add(this.rbtnFinite);
            this.grpbxUniverseType.Location = new System.Drawing.Point(17, 16);
            this.grpbxUniverseType.Name = "grpbxUniverseType";
            this.grpbxUniverseType.Size = new System.Drawing.Size(128, 82);
            this.grpbxUniverseType.TabIndex = 0;
            this.grpbxUniverseType.TabStop = false;
            this.grpbxUniverseType.Text = "Universe Type";
            // 
            // rbtnFinite
            // 
            this.rbtnFinite.AutoSize = true;
            this.rbtnFinite.Checked = true;
            this.rbtnFinite.Location = new System.Drawing.Point(6, 19);
            this.rbtnFinite.Name = "rbtnFinite";
            this.rbtnFinite.Size = new System.Drawing.Size(50, 17);
            this.rbtnFinite.TabIndex = 0;
            this.rbtnFinite.TabStop = true;
            this.rbtnFinite.Text = "Finite";
            this.rbtnFinite.UseVisualStyleBackColor = true;
            // 
            // rbtnToroidal
            // 
            this.rbtnToroidal.AutoSize = true;
            this.rbtnToroidal.Location = new System.Drawing.Point(6, 42);
            this.rbtnToroidal.Name = "rbtnToroidal";
            this.rbtnToroidal.Size = new System.Drawing.Size(63, 17);
            this.rbtnToroidal.TabIndex = 1;
            this.rbtnToroidal.TabStop = true;
            this.rbtnToroidal.Text = "Toroidal";
            this.rbtnToroidal.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.optOKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.optCancelBtn;
            this.ClientSize = new System.Drawing.Size(377, 300);
            this.Controls.Add(this.tbctrlMain);
            this.Controls.Add(this.optCancelBtn);
            this.Controls.Add(this.optOKBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.tbctrlMain.ResumeLayout(false);
            this.tbpgGeneral.ResumeLayout(false);
            this.tbpgGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.tbpgView.ResumeLayout(false);
            this.tbpgView.PerformLayout();
            this.tbpgAdvanced.ResumeLayout(false);
            this.grpbxUniverseType.ResumeLayout(false);
            this.grpbxUniverseType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optOKBtn;
        private System.Windows.Forms.Button optCancelBtn;
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
        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.GroupBox grpbxUniverseType;
        private System.Windows.Forms.RadioButton rbtnToroidal;
        private System.Windows.Forms.RadioButton rbtnFinite;
    }
}