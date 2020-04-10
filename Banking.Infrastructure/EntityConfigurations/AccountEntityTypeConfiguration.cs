using System;
using System.Collections.Generic;
using System.Text;
using Banking.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Banking.Infrastructure.EntityConfigurations
{
    class AccountEntityTypeConfiguration:IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne<Customer>()
                .WithMany()
                .HasForeignKey(e => e.CustomerId);
            builder.OwnsOne(e => e.AccountNumber);
            builder.HasOne(e => e.AccountType)
                .WithMany()
                .HasForeignKey(e=>e.AccountType.)                
    }
}
