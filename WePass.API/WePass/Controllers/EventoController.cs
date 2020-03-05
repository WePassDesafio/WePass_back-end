using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WePass.Domain.Exceptions;
using WePass.Domain.Model;
using WePass.Service.Interfaces;

namespace WePass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        public IEventoService _eventoService;
        public string retorno = "";
        public Evento _evento;

        public EventoController(IEventoService eventoService)
        {
            _eventoService = eventoService;
        }

        [HttpGet("BuscarEvento")]
        public Evento BuscarEvento(Guid id)
        {
            return _eventoService.BuscarEventoPorIdService(id);
        }

        [HttpPost("CadastrarEvento")]
        public string CadastrarEvento(Evento evento)
        {
            try
            {
                retorno = _eventoService.CadastrarEventoService(evento);

            }
            catch (WePassExceptions error)
            {

                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPost("AtivarEvento")]
        public string AtivarEvento(Guid id)
        {
            try
            {
                retorno = _eventoService.AtivarEventoService(id);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPut("EditarEvento")]
        public Evento EditarEvento(Evento evento)
        {
            try
            {
                _evento = _eventoService.EditarEventoService(evento);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return _evento;
        }


        [HttpDelete("DesativarEvento")]
        public string DesativarEvento(Guid id)
        {
            try
            {
                retorno = _eventoService.DesativarEventoService(id);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }
    }
}