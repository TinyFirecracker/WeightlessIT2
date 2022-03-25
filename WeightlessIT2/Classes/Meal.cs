using System.Collections.Generic;

namespace WeightlessIT2
{
    internal class Meal
    {

        private List<string> mealList = new List<string>();

        public void AddMeal(string meal)
        {
            mealList.Add(meal);
        }

        public List<string> GetList()
        {
            return mealList;
        }
    }
}
