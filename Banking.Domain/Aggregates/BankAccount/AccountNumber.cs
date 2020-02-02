using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class AccountNumber:ValueObject
    {
        public string Number { get; set; }

        public AccountNumber(string code,string nationalCode)
        {
            Number = code + nationalCode;
        }
    }
}