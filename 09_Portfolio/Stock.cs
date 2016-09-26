using System;

namespace _09_Portfolio
{
    internal class Stock
    {
        public int NumShares { get; internal set; }

        public double PricePerShare { get; internal set; }

        public string Symbol { get; internal set; }

        public Stock()
        {

        }
        public Stock(string symbol, double priceshare, int amount)
        {
            this.Symbol = symbol;
            this.PricePerShare = priceshare;
            this.NumShares = amount;
        }
        internal double GetValue()
        {
           return (double) (NumShares * PricePerShare);
           
        }

        internal static double TotalValue(Stock[] stocks)
        {
            double totalvalue = 0;
            foreach (Stock s in stocks) 
            {
                double valueShare = (double)(s.NumShares * s.PricePerShare);
                totalvalue = totalvalue + valueShare ;
            }
            return totalvalue ;
        }
        public override string ToString()
        {   

            string str = "Stock[symbol="+ this.Symbol + ",pricePerShare="+this.PricePerShare+",numShares=" + this.NumShares+ "]"  ;
            return str;
        }
        public override bool Equals(object obj)
        {
            Stock s = (Stock)obj;
            if (this.NumShares == s.NumShares && this.PricePerShare == s.PricePerShare && this.Symbol == s.Symbol)
                return true;
      
            return false;
        }
    }
}