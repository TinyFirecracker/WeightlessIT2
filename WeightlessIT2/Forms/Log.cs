using System;
using System.Windows.Forms;

namespace WeightlessIT2
{
    public partial class Log : Form
    {
        Meal meal = new Meal();
        public Log()
        {
            InitializeComponent();
        }

        private void plusBreakfastButton_Click(object sender, EventArgs e)
        {
            Breakfastlog breakfastlog = new Breakfastlog(meal.GetList());
            breakfastlog.Show();
        }

        private void plusLunchButton_Click(object sender, EventArgs e)
        {
            Lunchlog lunchlog = new Lunchlog(meal.GetList());
            lunchlog.Show();
        }

        private void plusDinnerButton_Click(object sender, EventArgs e)
        {
            Dinnerlog dinnerlog = new Dinnerlog(meal.GetList());
            dinnerlog.Show();
        }

        private void plusSnacksButton_Click(object sender, EventArgs e)
        {
            Snacklog snacklog = new Snacklog(meal.GetList());
            snacklog.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
