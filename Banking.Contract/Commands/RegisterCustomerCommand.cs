using System;
using System.Collections.Generic;
using System.Text;
using Banking.Contract.SeedWork;

namespace Banking.Contract.Commands
{
    public class RegisterCustomerCommand:ICommand
    {
        public Guid Customer { get; set; }
        public string NationalCode { get; private set; }
        public DateTime Birth { get; private set; }
        public int Gender { get; private set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Phone { get; private set; }
        public string Mobile { get; private set; }

        public RegisterCustomerCommand(Guid customer, 
            string nationalCode, 
            DateTime birth, 
            int gender, string city, 
            string postalCode, 
            string street, 
            string phone, 
            string mobile)
        {
            Customer =  customer;
            NationalCode = nationalCode;
            Birth = birth;
            Gender = gender;
            City = city;
            PostalCode = postalCode;
            Street = street;
            Phone = phone;
            Mobile = mobile;
        }
    }
}
