using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Banking.Contract.Commands;
using Banking.Contract.SeedWork;
using Microsoft.Extensions.DependencyInjection;

namespace Banking.Application.CommandHandlers
{
    public class CommandDispatcher:ICommandDispatcher
    {
        private readonly IServiceProvider serviceProvider;


        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public Task Dispatch<T>(T command) where T : ICommand
        {

            var commandHandler = serviceProvider.GetRequiredService<ICommandHandler<T>>();
            commandHandler.Handle(command);
            return Task.CompletedTask;
        }
    }
}
