using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Banking.Contract.SeedWork;

namespace Banking.Application
{
    class TransactionalCommandDispatcher: ICommandDispatcher
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IUnitOfWork _unitOfWork;

        public TransactionalCommandDispatcher(ICommandDispatcher commandDispatcher, IUnitOfWork unitOfWork)
        {
            _commandDispatcher = commandDispatcher;
            this._unitOfWork = unitOfWork;
        }

        public async Task Dispatch<T>(T command) where T : ICommand
        {
            //unitOfWork.BeginTransaction
            try
            {
                await _commandDispatcher.Dispatch(command);
                await _unitOfWork.SaveAsync();
            }
            catch (ApplicationException applicationException)
            {
                Console.WriteLine($"------Error occurred a CommandDispatcher. Exception: {@applicationException}-----", applicationException);
                Console.WriteLine($"------Dispatched command is {@command}-----", command);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception occurred. {@ex}", ex);
                throw;
            }
           
        }
    }
}
