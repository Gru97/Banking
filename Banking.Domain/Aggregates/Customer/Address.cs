using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class Address: ValueObject
    {
        public Address(string street, string city, string postalCode)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string PostalCode { get; private set; }
        
    }
}