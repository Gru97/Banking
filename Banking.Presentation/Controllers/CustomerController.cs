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
        private readonly ICommandHandler commandHandler;

        public CustomerController(ICommandHandler commandHandler)
        {
            this.commandHandler = commandHandler;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var birth=new DateTime(1997,08,25);
            commandHandler.Send<RegisterCustomerCommand>(new RegisterCustomerCommand(Guid.NewGuid(),"1200183347", birth,true,"021333333","09135490057"));
            return Accepted();
        }
    }
}