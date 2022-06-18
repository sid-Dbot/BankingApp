using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public  class Bankacc
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance  { get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amt;
                }
                return balance;
            } }

        private static int AccNoSeed = 987654321;

        private List<Transaction> allTransactions= new List<Transaction>(); 

        public Bankacc(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "initial Balance");
            this.Number = AccNoSeed.ToString();
            AccNoSeed += 7;
        }

        public void MakeDeposit(decimal Amt,DateTime Date,string Note)
        {
            if(Amt<=0)
                throw new ArgumentOutOfRangeException(nameof(Amt),"Amount of deposit must be positive.");
            var deposit= new Transaction(Amt,Date,Note);    
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal Amt, DateTime Date, string Note)
        {
            if (Amt <= 0)
                throw new ArgumentOutOfRangeException(nameof(Amt), "Amount of withdrawal must be positive.");
            if (Balance - Amt < 0)
                throw new ArgumentOutOfRangeException("Not sufficients funds for the withdrawal");
            var withdrawal=new Transaction(-Amt,Date,Note);
            allTransactions.Add(withdrawal);
        }
        public string getHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date \t\t Amount \t\t Notes");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t\t{item.Amt}\t\t{item.Note}");
            }
            return report.ToString();

        }
           
    }
}
