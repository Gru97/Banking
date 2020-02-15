using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Aggregates.Customer
{
    public interface ICustomerRepository
    {
        Task Insert(Domain.Customer customer);
    }
}
