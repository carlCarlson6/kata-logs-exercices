using System.Collections.Generic;

namespace BankingAccount.Printer
{
    public interface ITransactionsPrinter
    {
        void Print(IList<Transaction> transactions);
    }
}
