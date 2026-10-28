using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDesigner
{
    public partial class NodeSettings : Form
    {
        public Color Colour => colourIconLabel.BackColor;
        public new int Width => (int)widthValNumericUD.Value;

        public NodeSettings(Color c, int w)
        {
            InitializeComponent();
            colourIconLabel.BackColor = c;
            widthValNumericUD.Value = w;
        }

        private void colourIconLabel_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog() { Color = Colour };
            if (col.ShowDialog() == DialogResult.OK)
            {
                colourIconLabel.BackColor = col.Color;
            }
        }
    }
}
