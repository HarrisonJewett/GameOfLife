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
    public partial class Seed : Form
    {
        Random RNG = new Random();

        public Seed()
        {
            InitializeComponent();
        }

        private void btnRandomSeed_Click(object sender, EventArgs e)
        {
            nudSeed.Value = RNG.Next(999999999);
        }

        public int worldSeed
        {
            get
            {
                return (int)nudSeed.Value;
            }
            set
            {
                nudSeed.Value = value;
            }
        }
    }
}
