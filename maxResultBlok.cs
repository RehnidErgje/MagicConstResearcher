using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicConstResearcher
{
    public partial class maxResultBlok : UserControl
    {
        private ResearchPage parent;
        public int index;

        public string max
        {
            get { return maxP.Text; }
            private set { maxP.Text = value; }
        }

        public string min
        {
            get { return maxN.Text; }
            private set { maxN.Text = value; }
        }
        public string maxpos
        {
            get { return xP.Text; }
            private set { xP.Text = value; }
        }

        public string minpos
        {
            get { return xN.Text; }
            private set { xN.Text = value; }
        }
        public maxResultBlok(string name, Color color, double xp, double xn, double maxp, double maxn, ResearchPage _parent)
        {
            InitializeComponent();
            Border.Text = name;
            Border.ForeColor = color;
            max = maxp.ToString("E13");
            min = maxn.ToString("E13");
            maxpos = xp.ToString("F7");
            minpos = xn.ToString("F7");
            parent = _parent;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            parent.ResearchRemove(index);
        }
    }
}
