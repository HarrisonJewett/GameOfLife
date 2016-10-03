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
        public Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = btnGrid.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                btnGrid.BackColor = dlg.Color;
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = btnBackgroundColor.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                btnBackgroundColor.BackColor = dlg.Color;
            }
        }

        private void btnCellColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

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
    }
}
