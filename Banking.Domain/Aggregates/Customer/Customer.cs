using System;
using System.Collections.Generic;
using System.Text;
using Banking.Contract.DomainEvents;
using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class Customer: Entity,IAggregateRoot
    {
        private string _nationalCode;
        private DateTime _birth;
        private string _mobile;
        private int _gender;
        private Address _homeAddress;
        private Phone _phone;
        private List<AccountNumber> _bankAcounts;

        public string NationalCode
        {
            get => _nationalCode;
            private set => _nationalCode = value;
        }
        public DateTime Birth
        {
            get => _birth;
            private set => _birth = value;
        }
        public int Gender
        {
            get => _gender;
            private set => _gender = value;
        }
        public Address HomeAddress
        {
            get => _homeAddress;
            private set => _homeAddress = value;
        }
        public Phone Phone
        {
            get => _phone;
            private set => _phone = value;
        }

        public string Mobile
        {
            get => _mobile;
            private set => _mobile = value;
        }

        public IReadOnlyCollection<AccountNumber> BankAcounts => _bankAcounts;
        private Customer()
        {
        }

        public Customer(string nationalCode,
            DateTime birth, 
            int gender,
            Address homeAddress,
            Phone phone, 
            string mobile)
        {
            SetNationalCode(nationalCode);
            SetBirth(birth);
            _gender = gender;
            _homeAddress = homeAddress;
            _phone = phone;
            SetMobile(mobile);

            var @event = new CustomerCreatedDomainEvent(nationalCode);
                
            Events.Add(@event);
             
        }

        private void SetMobile(string mobile)
        {
            if(mobile.Length!=11 || !mobile.StartsWith("09"))
                throw new Exception("Mobile Number is not valid");
            _mobile = mobile;

        }

        private void SetBirth(DateTime birth)
        {
            var age = DateTime.Now.Date.Year - birth.Date.Year;
            if(age<18)
                throw new Exception("A customer of age bellow 18 can't have bank account");
            _birth = birth;
        }

        private void SetNationalCode(string code)
        {
          //skipped the algorithm in detail for now
            if(code.Length!=10)
                throw new  Exception("National Code is not valid");
            _nationalCode = code;


        }
    }
}
