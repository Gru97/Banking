using System;
using System.Collections.Generic;
using System.Text;
using Banking.Domain.SeedWork;

namespace Banking.Domain
{
    public class Customer: Entity,IAggregateRoot
    {
        public string NationalCode { get; private set; }
        public DateTime Birth { get; private set; }
        public bool Gender { get; private set; }
        public Address HomeAddress { get; private set; }
        public Phone Phone { get; private set; }
        public string Mobile { get; private set; }

        public void Register(string nationalCode,
            DateTime birth, bool gender,
            Address homeAddress,
            Phone phone, string mobile)
        {
            SetNationalCode(nationalCode);
            SetBirth(birth);
            Gender = gender;
            HomeAddress = homeAddress;
            Phone = phone;
            SetMobile(mobile);
        }

        private void SetMobile(string mobile)
        {
            if(mobile.Length!=11 || !mobile.StartsWith("09"))
                throw new Exception("Mobile Number is not valid");
            Mobile = mobile;

        }

        private void SetBirth(DateTime birth)
        {
            var age = DateTime.Now.Date.Year - birth.Date.Year;
            if(age<18)
                throw new Exception("A customer of age bellow 18 can't have bank account");
            Birth = birth;
        }

        

        private void SetNationalCode(string code)
        {
          //skipped the algorithm in detail for now
            if(code.Length!=10)
                throw new  Exception("National Code is not valid");
            NationalCode = code;


        }
    }
}
