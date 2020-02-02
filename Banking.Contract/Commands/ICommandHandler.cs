using Banking.Contract.Commands;

namespace Banking.Contract.Commands
{
    public interface ICommandHandler
    {
        void Send<TCommand>(TCommand command) where TCommand:ICommand;
    }
}