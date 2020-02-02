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
        public AccontType Type { get; set; }
        public int Customer { get; set; }

    }

    public class AccountNumber
    {
    }
}
