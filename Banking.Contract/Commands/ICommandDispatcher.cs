using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Contract.Commands
{
    public interface ICommandDispatcher
    {
        Task Dispatch<T>(T command) where  T:ICommand;
    }
}
