using System;
using System.Collections.Generic;
using System.Linq;

namespace BankingAccount
{
    public class Account
    {
        private IList<Transaction> transactions;
        public IList<Transaction> Transactions { get => this.transactions; }
    
        private int balance;
        public int Balance { get => this.balance; }

        public Account()
        {
            this.transactions = new List<Transaction>();
            this.balance = 0;
        }

        public void Deposit(int amount) 
        {
            this.ValidateAmount(amount);
            this.UpdateAccount(amount);
        }
        public void WithDraw(int amount) 
        {
            this.ValidateAmount(amount);
            this.UpdateAccount(-amount);
        }
        public void ValidateAmount(int amount)
        {
            if(amount == 0)
                throw new Exception("input amount can not be 0");
            if(amount < 0)
                throw new Exception("input amount can not be negative");
        }
    
        private int CalculateBalance(int newAmount) 
        {
            int balance;

            if(this.transactions.Count != 0)
            {
                balance = this.transactions.ToList().Last().Balance + newAmount;
            }
            else 
            {
                balance = newAmount;
            }

            return balance;
        }
        private void UpdateAccount(int amount)
        {
            int newBalance = this.CalculateBalance(amount);
            Transaction newTransaction = new Transaction(amount, newBalance);

            this.balance = newBalance;
            this.transactions.Add(newTransaction);
        }
    }
}
