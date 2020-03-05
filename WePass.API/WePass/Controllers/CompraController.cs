using Microsoft.AspNetCore.Mvc;
using System;
using WePass.Domain.Exceptions;
using WePass.Domain.Model;
using WePass.Service.Interfaces;

namespace WePass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        public ICompraService _compraService;
        public string retorno = "";
        public Compra purchase;

        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        }

        [HttpGet("BuscarCompra")]
        public Compra BuscarUsuario(Guid id)
        {
            return _compraService.BuscarCompraPorIdService(id);
        }

        [HttpPost("CadastrarCompra")]
        public string CadastrarCompra(Compra compra)
        {

            try
            {
                retorno = _compraService.CadastrarCompraService(compra);

            }
            catch (WePassExceptions error)
            {

                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPost("AtivarCompra")]
        public string AtivarUsuario(Guid id)
        {
            try
            {
                retorno = _compraService.AtivarCompraService(id);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPut("EditarCompra")]
        public Compra EditarCompra(Compra compra)
        {
            try
            {
                purchase = _compraService.EditarCompraService(compra);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return purchase;
        }


        [HttpDelete("DesativarCompra")]
        public string DesativarCompra(Guid id)
        {
            try
            {
                retorno = _compraService.DesativarCompraService(id);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }
    }
}