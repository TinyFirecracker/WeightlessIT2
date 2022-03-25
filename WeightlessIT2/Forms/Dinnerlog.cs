using System.Collections.Generic;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class Dinnerlog : Form
    {
        public Dinnerlog(List<string> meal)
        {
            InitializeComponent();
            foreach (var item in meal)
            {
                overviewDinnerBox.Items.Add(item);
            }
        }
    }
}
