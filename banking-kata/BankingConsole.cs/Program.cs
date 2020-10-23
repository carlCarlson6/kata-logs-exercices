using System;
using BankingAccount;
using BankingAccount.Printer;

namespace BankingConsole.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
            Account account = new Account();

            account.Deposit(100);
            account.WithDraw(30);
            account.Deposit(50);
            account.WithDraw(200);

            ITransactionsPrinter printer = new ConsolePrinter();
            
            printer.Print(account.Transactions);
        }
    }
}
