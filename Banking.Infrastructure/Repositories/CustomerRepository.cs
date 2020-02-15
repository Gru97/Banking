using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;
using Banking.Domain.Aggregates.Customer;

namespace Banking.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task Insert(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
