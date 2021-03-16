using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compute_Click(object sender, EventArgs e)
        {
            Double.TryParse(billBox.Text, out double bill);
            Double.TryParse(tipPercentageBox.Text, out double tip);
            tipBox.Text = (.01 * tip * bill).ToString();
            totallyAmountBox.Text = ((.01 * tip * bill) + bill).ToString();
        }

        private void billBox_TextChanged(object sender, EventArgs e)
        {
            compute.Enabled = Double.TryParse(billBox.Text, out _) && Double.TryParse(tipBox.Text, out _);
            if (compute.Enabled)
                compute_Click(sender, e);
        }


        private void TipBox_TextChanged(object sender, EventArgs e)
        {
            compute.Enabled = Double.TryParse(billBox.Text, out _) && Double.TryParse(tipBox.Text, out _);
            if (compute.Enabled)
                compute_Click(sender, e);
        }
    }
}
