using System.Collections.Generic;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class Snacklog : Form
    {
        public Snacklog(List<string> meal)
        {
            InitializeComponent();

            foreach (var item in meal)
            {
                overviewSnackBox.Items.Add(item);
            }
        }
    }
}
