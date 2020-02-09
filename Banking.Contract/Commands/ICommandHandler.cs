using Banking.Contract.Commands;

namespace Banking.Contract.Commands
{
    public interface ICommandHandler<in T>where T:ICommand
    {
        void Send(T command) ;
    }
}