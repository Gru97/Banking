namespace Banking.Contract.SeedWork
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<in T> where T : ICommand
    {
        void Handle(T command);
    }
}
