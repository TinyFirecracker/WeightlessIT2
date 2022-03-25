using System.Collections.Generic;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class Breakfastlog : Form
    {
        public Breakfastlog(List<string> meal)
        {
            InitializeComponent();

            foreach (var item in meal)
            {
                overviewMealBox.Items.Add(item);
            }
        }
    }
}
