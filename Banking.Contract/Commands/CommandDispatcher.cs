using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Banking.Contract.Commands
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
            commandHandler.Send(command);
            return Task.CompletedTask;
        }
    }
}
