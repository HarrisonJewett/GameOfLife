using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGame
{
    public partial class Options : Form
    {
        ColorDialog dlg = new ColorDialog();

        public Options()
        {
            InitializeComponent();
            dlg.Color = btnGrid.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dlg.Color = btnGrid.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                btnGrid.BackColor = dlg.Color;
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {

            dlg.Color = btnBackgroundColor.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                btnBackgroundColor.BackColor = dlg.Color;
            }
        }

        private void btnCellColor_Click(object sender, EventArgs e)
        {

            dlg.Color = btnCellColor.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                btnCellColor.BackColor = dlg.Color;
            }
        }

        public int xAxis
        {
            get
            {
                return (int)nudXAxis.Value;
            }
            set
            {
                nudXAxis.Value = value;
            }
        }
        public int yAxis
        {
            get
            {
                return (int)nudYAxis.Value;
            }
            set
            {
                nudYAxis.Value = value;
            }
        }

        public int milTimer
        {
            get
            {
                return (int)nudTimer.Value;
            }
            set
            {
                nudTimer.Value = value;
            }
        }

        public Color gridColors
        {
            get
            {
                return btnGrid.BackColor;
            }
            set
            {
                btnGrid.BackColor = value;
            }
        }
        public Color backgroundColors
        {
            get
            {
                return btnBackgroundColor.BackColor;
            }
            set
            {
                btnBackgroundColor.BackColor = value;
            }
        }
        public Color cellColors
        {
            get
            {
                return btnCellColor.BackColor;
            }
            set
            {
                btnCellColor.BackColor = value;
            }
        }

        public bool universeType
        {
            get
            {
                return rbtnFinite.Checked;
            }
            set
            {
                if (value)
                    rbtnFinite.Checked = true;
                else
                    rbtnToroidal.Checked = true;
            }
        }
    }
}
