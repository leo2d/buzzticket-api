using BuzzTicket.Api.ViewModels;
using BuzzTicket.Domain.TicketAgg;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuzzTicket.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            return Ok(new List<Ticket>() { new Ticket() { Aberto = true, Solicitacao = "sdad", Solicitante = "qwdqwdqwdqdw" } });
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] TicketViewModel ticketViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Dados informados são inválidos");

            return Created("", "");
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] TicketViewModel ticketViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Dados informados são inválidos");

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir([FromQuery] Guid id)
        {
            if (id == null || id == Guid.Empty) return BadRequest("Dados informados são inválidos");

            return NoContent();
        }

    }
}
