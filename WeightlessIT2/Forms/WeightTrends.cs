using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class WeightTrends : Form
    {
        public WeightTrends(List<decimal> logweight)
        {
            InitializeComponent();
            foreach (var log in logweight)
            {
                overviewWeightBox.Items.Add(log.ToString());
            }
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            Logweight logweight = new Logweight();
            logweight.Show();
            this.Close();
        }
    }
}
