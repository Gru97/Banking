using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Contract.SeedWork
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
        void Save();
    }
}
