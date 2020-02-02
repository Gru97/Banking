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
        public IActionResult Post(RegisterCustomerCommand command)
        {

        }
    }
}