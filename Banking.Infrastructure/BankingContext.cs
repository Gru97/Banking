using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Banking.Contract.SeedWork;
using Banking.Domain;
using Banking.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Banking.Infrastructure
{
    public class BankingContext:DbContext,IUnitOfWork
    {
        public DbSet<Customer> Customers{ get; set; }
        public BankingContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
        }

        public void Save()
        {
            this.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await this.SaveChangesAsync();
        }
    }
}
