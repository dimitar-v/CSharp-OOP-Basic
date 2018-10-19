using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balamce;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public decimal Balance
        {
            get { return this.balamce; }
            set { this.balamce = value; }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Account ID{this.Id}, balance {this.Balance:f2}";
        }
    }
}