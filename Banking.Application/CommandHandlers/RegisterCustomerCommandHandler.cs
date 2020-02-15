using System;
using System.Collections.Generic;
using System.Text;
using Banking.Contract.Commands;
using Banking.Contract.SeedWork;
using Banking.Domain;
using Banking.Domain.Aggregates.Customer;

namespace Banking.Application.CommandHandlers
{
    public class RegisterCustomerCommandHandler:ICommandHandler<RegisterCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public RegisterCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Handle(RegisterCustomerCommand command)
        {
            var homeAddress=new Address(command.Street,command.City,command.PostalCode);
            var phone=new Phone(command.Phone.Substring(0,3), command.Phone.Substring(3));
            var customer = new Customer(command.NationalCode,
                command.Birth,
                command.Gender,
                homeAddress,
                phone,
                command.Mobile);

            _customerRepository.Insert(customer);

        }
    }

}
