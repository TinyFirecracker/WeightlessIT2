using System;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void startButton1_Click_1(object sender, EventArgs e)
        {
            Logweight logweight = new Logweight();
            logweight.Show();
            this.Hide();
        }

        private void startButton2_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.Show();
            this.Hide();
        }
    }
}
