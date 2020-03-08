using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WePass.Domain.Exceptions;
using WePass.Domain.Model;
using WePass.Infra;
using WePass.Infra.Interfaces;
using WePass.Infra.Libraries.Lang;
using WePass.Service.Interfaces;

namespace WePass.Service.Services
{
    public class EventoService : IEventoService
    {

        #region Atributos

        private readonly IMapper _mapper;
        private readonly IRepositoryUnitOfWork _unitOfWork;

        #endregion

        #region Construtor

        public EventoService(IRepositoryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }
        public string AtivarEventoService(Guid id)
        {
            var desativarEvento = BuscarEventoPorIdService(id);

            if (desativarEvento.Active != true)
            {
                desativarEvento.Active = true;

                _unitOfWork.Evento.Update(desativarEvento);
                _unitOfWork.Commit();
                return Message.MSG_S002;
            }

            return Message.MSG_S003;
        }

        public Evento BuscarEventoPorIdService(Guid id)
        {
            var evento = _unitOfWork.Evento.Query(a => a.Id == id);

            if (evento == null)
            {
                throw new WePassExceptions("Evento invalido");
            }

            return evento;
        }

        public List<Evento> BuscarTodosEventorPorId(Evento evento)
        {
            List<Evento> autor = new List<Evento>();

            autor = _unitOfWork.Evento.List().OrderBy(x => x.NomeEvento).ToList();


            if (autor == null)
            {
                throw new WePassExceptions("Usuario invalido");
            }

            return autor;
        }

        public List<Evento> BuscarTodosEventos()
        {
            List<Evento> EventoOn = new List<Evento>();

            EventoOn = _unitOfWork.Evento.List().OrderBy(x => x.Active != false).ToList();


            if (EventoOn == null)
            {
                throw new WePassExceptions("Evento invalido");
            }

            return EventoOn;
        }

        public string CadastrarEventoService(Evento evento)
        {
            var Cadastrar = BuscarTodosEventorPorId(evento);

            bool verificandoEvento = false;

            foreach (var user in Cadastrar)
            {
                if (user.NomeEvento == evento.NomeEvento && user.DataEvento == evento.DataEvento && evento.Categoria == user.Categoria)
                {
                    verificandoEvento = true;
                }
            }

            if (verificandoEvento == false)
            {
                _unitOfWork.Evento.Add(evento);
                _unitOfWork.Commit();
                return Message.MSG_S001;
            }
            return Message.MSG_S004;
        }

        public string DesativarEventoService(Guid id)
        {
            var desativarEvento = BuscarEventoPorIdService(id);

            if (desativarEvento.Active != false)
            {
                desativarEvento.Active = false;

                _unitOfWork.Evento.Update(desativarEvento);
                _unitOfWork.Commit();
                return Message.MSG_D001;
            }

            return Message.MSG_D003;
        }

        public Evento EditarEventoService(Evento evento)
        {
            var editarEvento = BuscarEventoPorIdService(evento.Id);

            if (editarEvento != null)
            {
                _unitOfWork.Evento.Update(evento);
                _unitOfWork.Commit();
            }

            return evento;
        }
    }

    #endregion
}
