using System;
using System.Collections.Generic;
using System.Text;
using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class BankAccount:Entity,IAggregateRoot
    {
        private decimal _balance;
        private Guid _customerId;
        private AccountType _accountType;
        private AccountNumber _accountNumber;

        public decimal Balance
        {
            get => _balance;
            private set => _balance = value;
        }

        public AccountNumber AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }

        public AccountType AccountType
        {
            get => _accountType;
            private set => _accountType = value;
        }

        public Guid CustomerId
        {
            get => _customerId;
            private set => _customerId = value;
        }
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

        public void OpenAccount(AccountType type, Guid customerId, decimal balance)
        {
            _balance = balance;
            _accountType = type;
            _customerId = customerId;

        }

       
    }
}
