using System.Collections.Generic;

namespace WeightlessIT2
{
    public class Weight
    {
        //private decimal WeighIn { get; set; }
        private List<decimal> prvweight = new List<decimal>();

        public void AddWeighIn(decimal weighIn)
        {
            prvweight.Add(weighIn);
        }

        public List<decimal> GetList()
        {
            return prvweight;
        }

    }
}
