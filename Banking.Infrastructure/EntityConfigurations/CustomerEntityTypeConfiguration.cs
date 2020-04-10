using System;
using System.Collections.Generic;
using System.Text;
using Banking.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Banking.Infrastructure.EntityConfigurations
{
    class CustomerEntityTypeConfiguration:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.Id);
            builder.OwnsOne(e => e.HomeAddress);
            builder.OwnsOne(e => e.Phone);
            
            builder.Ignore(e => e.Events);


        }
    }
}
