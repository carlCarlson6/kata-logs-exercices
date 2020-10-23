using System;

namespace BankingAccount
{
    public class Transaction
    {
        public DateTime Date { get; }
        public int Amount { get; }
        public int Balance { get; }

        public Transaction(int amount, int balance)
        {
            this.Date = DateTime.Now;
            this.Amount = amount;
            this.Balance = balance;
        }
    }
}
