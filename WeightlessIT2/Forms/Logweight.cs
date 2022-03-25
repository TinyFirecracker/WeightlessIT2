using System;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class Logweight : Form
    {
        public Logweight()
        {
            InitializeComponent();
        }

        Weight weight = new Weight();


        private void submitWeight_Click(object sender, EventArgs e)
        {
            weight.AddWeighIn(numericUpDown1.Value);
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void weightTrendsButton_Click(object sender, EventArgs e)
        {
            WeightTrends weighTrends = new WeightTrends(weight.GetList());
            weighTrends.Show();
            this.Close();
        }
    }
}
