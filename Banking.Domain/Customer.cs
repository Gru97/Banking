using System;
using System.Collections.Generic;
using System.Text;
using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class Customer: Entity,IAggregateRoot
    {
        public NationalCode NationalCode { get; set; }
        public DateTime Birth { get; set; }
        public bool Gender { get; set; }
        public Address HomeAddress { get; set; }
        public Phone Phone { get; set; }
        public string Mobile { get; set; }
    }

    public class Phone:ValueObject
    {
        public string Code { get; private set; }
        public string Number { get; private set; }

        public Phone(string code, string number)
        {
            Code = code;
            Number = number;
        }
    }

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
