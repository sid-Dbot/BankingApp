using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Transaction
    {
        public decimal Amt { get; set; }    
        public DateTime Date { get; set; }
        public string Note { get; }

        public Transaction( decimal amt, DateTime date, string note)
        {
            Amt = amt;
            Date = date;
            Note = note;
        }
    }
}
