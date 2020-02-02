using System;
using System.Collections.Generic;
using System.Text;
using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class BankAccount:Entity,IAggregateRoot
    {
        public decimal Balance { get;private set; }
        public AccountNumber AccountNumber { get; private set; }
        public AccountType Type { get; private set; }
        public Guid CustomerId { get; private set; }

      

        public void Deposit(decimal value)
        {
            Balance += value;
        }
        public void Withdraw(decimal value)
        {
            if(Balance-value<0)
                throw new Exception("Balance is not enough for withdrawal");
            Balance -= value;

        }

        public void OpenAccount(AccountType type, Guid customerId, decimal balance, AccountType accountType)
        {
            Balance = balance;
            Type = type;
            CustomerId = customerId;
            Type = accountType;

        }

       
    }
}
