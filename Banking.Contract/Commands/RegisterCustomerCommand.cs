using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Contract.Commands
{
    public class RegisterCustomerCommand
    {
        public Guid Customer { get; set; }
        public string NationalCode { get; private set; }
        public DateTime Birth { get; private set; }
        public bool Gender { get; private set; }
        //public Address HomeAddress { get; private set; }
        public string Phone { get; private set; }
        public string Mobile { get; private set; }

        public RegisterCustomerCommand(Guid customer,
            string nationalCode,
            DateTime birth,
            bool gender,
            string phone,
            string mobile)
        {
            Customer = customer;
            NationalCode = nationalCode;
            Birth = birth;
            Gender = gender;
            Phone = phone;
            Mobile = mobile;
        }
    }
}
