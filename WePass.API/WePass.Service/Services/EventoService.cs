using System;
using System.Collections.Generic;
using WePass.Domain.Model;
using WePass.Service.Interfaces;

namespace WePass.Service.Services
{
    public class EventoService : IEventoService
    {
        public string AtivarEventoService(Guid id)
        {
            throw new NotImplementedException();
        }

        public Evento BuscarEventoPorIdService(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> BuscarTodosEventorPorId(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public string CadastrarEventoService(Evento evento)
        {
            throw new NotImplementedException();
        }

        public string DesativarEventoService(Guid id)
        {
            throw new NotImplementedException();
        }

        public Evento EditarEventoService(Evento evento)
        {
            throw new NotImplementedException();
        }
    }
}
