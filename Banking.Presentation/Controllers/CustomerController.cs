using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Contract.Commands;
using Banking.Contract.SeedWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICommandDispatcher commandDispatcher;

        public CustomerController(ICommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var birth=new DateTime(1997,08,25);
            var command =
                new RegisterCustomerCommand(Guid.NewGuid(), 
                    "1200183347", 
                    birth,
                    0, 
                    "Esfahan",
                    "123",
                    "Foroughi",
                    "021333333", 
                    "09135490057");
            await commandDispatcher.Dispatch<RegisterCustomerCommand>(command);
            return Accepted();
        }
    }
}