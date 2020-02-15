using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Application.CommandHandlers;
using Banking.Contract.Commands;
using Banking.Contract.SeedWork;
using Banking.Domain.Aggregates.Customer;
using Banking.Infrastructure;
using Banking.Infrastructure.Repositories;
using Banking.Presentation.Controllers;
using Castle.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Banking.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<ICommandDispatcher>(sp => { return new CommandDispatcher(sp); });
            services.AddTransient<ICommandHandler<RegisterCustomerCommand>, RegisterCustomerCommandHandler> ();
            services.AddTransient<IEventBus,EventAggregator>();
            services.AddTransient<ICustomerRepository,CustomerRepository>();
            services.AddDbContext<BankingContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("BankingContext"));
            
            }, ServiceLifetime.Scoped);

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }

}
