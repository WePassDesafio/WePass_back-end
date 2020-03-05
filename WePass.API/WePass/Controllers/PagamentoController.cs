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
    public class PagamentoController : ControllerBase
    {
        public IPagamentoService _pagamentoService;
        public string retorno = "";
        public Pagamento pay;

        public PagamentoController(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        [HttpGet("BuscarPagamento")]
        public Pagamento BuscarPagamento(Guid id)
        {
            return _pagamentoService.BuscarPagamentoPorId(id);
        }

        [HttpPost("CadastrarPagamento")]
        public string CadastrarPagamento(Pagamento pagamento)
        {

            try
            {
                retorno = _pagamentoService.CadastrarPagamentoService(pagamento);

            }
            catch (WePassExceptions error)
            {

                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPost("AtivarPagamento")]
        public string AtivarPagamento(Guid id)
        {
            try
            {
                retorno = _pagamentoService.AtivarPagamentoService(id);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPut("EditarPagamento")]
        public Pagamento Pagamento(Pagamento pagamento)
        {
            try
            {
                pay = _pagamentoService.EditarPagamento(pagamento);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return pay;
        }

        [HttpDelete("DesativarPagamento")]
        public string DesativarPagamento(Pagamento pagamento)
        {
            try
            {
                retorno = _pagamentoService.DesativarPagamentoService(pagamento);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }
    }
}