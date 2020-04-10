using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class Phone:ValueObject
    {
        public string Code { get; private set; }
        public string Number { get; private set; }
        private Phone() { }
        public Phone(string code, string number)
        {
            Code = code;
            Number = number;
        }
    }
}