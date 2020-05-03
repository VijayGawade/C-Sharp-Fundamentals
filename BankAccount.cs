using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class BankAccount
    {
        // Members
        private string owner;
        private double amount;

        // Properties
        public string Ower
        {
            get
            {
                return owner;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }
        }

        public BankAccount(string ower,double amount)
        {
            this.owner = ower;
            this.amount = amount;
        }

        public static BankAccount operator + (BankAccount bank1,BankAccount bank2)
        {
            double newAmt = bank1.Amount + bank2.Amount;
            string newOwer = bank1.Ower+" + " + bank2.Ower;

            BankAccount bankAccount = new BankAccount(newOwer, newAmt);
            return bankAccount;
        }

        public static BankAccount operator +(BankAccount bank1, double amt)
        {
            double newAmt = bank1.Amount +amt;
            string newOwer = bank1.Ower;

            BankAccount bankAccount = new BankAccount(newOwer, newAmt);
            return bankAccount;
        }
    }
}
