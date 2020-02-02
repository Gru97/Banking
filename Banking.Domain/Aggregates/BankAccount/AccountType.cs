using System;
using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class AccountType:Entity
    {
        public string Title { get; private set; }
        public string Code { get; private set; }

        public AccountType(string title, string code)
        {
            Title = title;
            if(code.Length!=2)
                throw new Exception("Account type code is not valid");
            Code = code;

        }
    }
    
}
