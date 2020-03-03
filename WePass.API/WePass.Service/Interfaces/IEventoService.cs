using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model;

namespace WePass.Service.Interfaces
{
    public interface IEventoService
    {
        //Create
        string CadastrarEventoService(Evento evento);

        //Read
        Evento BuscarEventoPorIdService(Guid id);
        List<Evento> BuscarTodosEventorPorId(Usuario usuario);

        //Update
        Evento EditarEventoService(Evento evento);
        string AtivarEventoService(Guid id);

        //Delete
        string DesativarEventoService(Guid id);

    }
}
