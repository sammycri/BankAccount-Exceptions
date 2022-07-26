using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Exercicio155.Entities.Exceptions;

namespace Exercicio155.Entities
{
    internal class Account
    {
        public int AccNumber { get; set; }
        public string Owner { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int accNumber, string owner, double balance, double withdrawLimit)
        {
            AccNumber = accNumber;
            Owner = owner;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public double Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit.");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance.");
            }
            Balance = Balance - amount;
            return Balance;
        }

        public double Deposit(double amount)
        {
            if(amount < 0)
            {
                throw new DomainException("Deposit error: The deposit amount must be more than zero(ex: R$ 100.00).");
            }
            Balance = Balance + amount;
            return Balance;
        }

        public override string ToString()
        {
            return "Bank account data - "
                + "Account: "
                + AccNumber
                + ", Owner name: "
                + Owner
                + ", Balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture)
                + ", Withdraw Limit: "
                + WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
