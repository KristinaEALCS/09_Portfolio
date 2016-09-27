using System;

namespace _09_Portfolio
{
    internal class SavingsAccount:IAsset
    {
        private double balance = 0;

        
        public SavingsAccount()
        {

        }

        public SavingsAccount(string accountname, double balance, double interestrate)
        {
            this.InterestRate = interestrate;
            this.balance = balance;
            this.AccountName = accountname;
        }
        public double InterestRate
        {
            get;
            set;
        }

        public string AccountName
        {
            get;
            set;
        }

     

        public double GetValue()
        {
           
            return this.balance ;
        }

        public override string ToString()
        {
            return "SavingsAccount[" + "value="+ this.balance + ",interestRate="  + this.InterestRate + "]" ;
        }

        public void ApplyInterest()
        {
            this.balance += (this.balance / 100) * this.InterestRate;
            
        }
    }
}