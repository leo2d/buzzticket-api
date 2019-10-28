using BuzzTicket.Domain.SharedKernel.Interfaces;
using BuzzTicket.Domain.TicketAgg.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuzzTicket.Domain.TicketAgg.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TicketService(ITicketRepository ticketRepository, IUnitOfWork unitOfWork)
        {
            _ticketRepository = ticketRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AtualizarTicket(Ticket ticket)
        {
            await _ticketRepository.Atualizar(ticket);
            await _unitOfWork.Commit();
        }

        public async Task<Ticket> BuscarTicket(Guid id)
        {
            var resultado = await _ticketRepository.BuscarPorId(id);
            return resultado;
        }

        public async Task<IEnumerable<Ticket>> BuscarTickets()
        {
            var resultado = await _ticketRepository.BuscarTodos();
            return resultado;
        }

        public async Task<IEnumerable<Ticket>> BuscarTicketsOrdenadosPorMaiorData(int quantidade)
        {
            var resultado = await _ticketRepository.BuscarTicketsOrdenadosPorMaiorData(quantidade);
            return resultado;
        }

        public async Task CriarTicket(Ticket ticket)
        {
            await _ticketRepository.Criar(ticket);
            await _unitOfWork.Commit();
        }

        public async Task ExcluirTicket(Guid Id)
        {
            await _ticketRepository.Excluir(id: Id);
            await _unitOfWork.Commit();
        }
    }
}
