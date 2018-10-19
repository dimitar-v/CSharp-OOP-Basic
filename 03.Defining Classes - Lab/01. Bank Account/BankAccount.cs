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
            set { this.id = value;}
        }
        public decimal Balance
        {
            get { return this.balamce; }
            set { this.balamce = value; }
        }
    }
}
