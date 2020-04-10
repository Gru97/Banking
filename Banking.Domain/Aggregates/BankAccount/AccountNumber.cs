using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class AccountNumber : ValueObject
    {
        public string Number { get; private set; }

        private AccountNumber()
        {
            
        }
        public AccountNumber(string code, string nationalCode)
        {
            Number = code + nationalCode;
        }
    }
}