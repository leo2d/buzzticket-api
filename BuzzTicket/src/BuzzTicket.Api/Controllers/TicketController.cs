using AutoMapper;
using BuzzTicket.Api.ViewModels;
using BuzzTicket.Domain.TicketAgg;
using BuzzTicket.Domain.TicketAgg.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuzzTicket.Api.Controllers
{
    [ApiController]
    [Route("tickets")]
    public class TicketController : ControllerBase
    {
        private ITicketService _ticketService { get; set; }
        private IMapper _mapper { get; set; }

        public TicketController(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("ordenado-maior-data")]
        public async Task<IActionResult> BuscarOrdenadosPorMaiorData([FromQuery] int? quantidade)
        {
            var tickets = await _ticketService.BuscarTicketsOrdenadosPorMaiorData(quantidade ?? 20);

            var resultado = _mapper.Map<IEnumerable<TicketViewModel>>(tickets);

            return Ok(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            var tickets = await _ticketService.BuscarTickets();

            var resultado = _mapper.Map<IEnumerable<TicketViewModel>>(tickets);

            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] TicketViewModel ticketViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Dados informados são inválidos");

            var ticket = _mapper.Map<Ticket>(ticketViewModel);

            await _ticketService.CriarTicket(ticket);

            return Created("", "");
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] TicketViewModel ticketViewModel)
        {
            if (!ModelState.IsValid) return BadRequest("Dados informados são inválidos");

            var ticket = _mapper.Map<Ticket>(ticketViewModel);

            await _ticketService.AtualizarTicket(ticket);

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir([FromQuery] Guid id)
        {
            if (id == null || id == Guid.Empty) return BadRequest("Dados informados são inválidos");

            await _ticketService.ExcluirTicket(id);

            return NoContent();
        }

    }
}
