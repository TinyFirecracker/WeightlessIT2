using System.Collections.Generic;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class Lunchlog : Form
    {
        public Lunchlog(List<string> meal)
        {
            InitializeComponent();

            foreach (var item in meal)
            {
                overviewLunchBox.Items.Add(item);
            }
        }
    }
}
