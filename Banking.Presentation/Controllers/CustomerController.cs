using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Contract.Commands;
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
            await commandDispatcher.Dispatch<RegisterCustomerCommand>(new RegisterCustomerCommand(Guid.NewGuid(),"1200183347", birth,true,"021333333","09135490057"));
            return Accepted();
        }
    }
}