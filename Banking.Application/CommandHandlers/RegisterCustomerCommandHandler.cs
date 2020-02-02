using System;
using System.Collections.Generic;
using System.Text;
using Banking.Contract.Commands;

namespace Banking.Application.CommandHandlers
{
    public class RegisterCustomerCommandHandler:ICommandHandler<RegisterCustomerCommand>
    {
        public void Send(RegisterCustomerCommand command)
        {
            throw new NotImplementedException();
        }
    }

}
