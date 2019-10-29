using BuzzTicket.Domain.TicketAgg;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuzzTicket.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(new List<Ticket>() { new Ticket() { Aberto = true, Solicitacao = "sdad", Solicitante = "qwdqwdqwdqdw" } });
        }
    }
}
