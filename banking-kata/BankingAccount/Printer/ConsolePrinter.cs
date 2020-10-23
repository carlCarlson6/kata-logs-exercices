using System;
using System.Linq;
using System.Collections.Generic;

namespace BankingAccount.Printer
{
    public class ConsolePrinter : ITransactionsPrinter
    {
        public void Print(IList<Transaction> transactions)
        {
            Console.WriteLine("Data\t\tAmount\t\tBalance");

            transactions.ToList().ForEach(
                t => Console.WriteLine(t.Date+"\t"+t.Amount+"\t"+t.Balance)
            );
        }
    }
}
