using System.Collections.Generic;

namespace _09_Portfolio
{
    public class Portfolio
    {
        public List<IAsset> Assets
        {
            set;
            get;
        }
        public Portfolio()
        {
            Assets = new List<IAsset>();
            
        }
        public Portfolio (List<IAsset> something)
        {
            Assets = something;
        }
        public double GetTotalValue()
        {
            double totalvalue = 0;
            foreach (IAsset a in Assets)
            {
                totalvalue += a.GetValue(); 
            }

            return totalvalue;
        }
        public void AddAsset(IAsset a)
        {
            Assets.Add(a);
            
        }


    }
}