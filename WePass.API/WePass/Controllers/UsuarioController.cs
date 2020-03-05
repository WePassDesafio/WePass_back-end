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
    public class UsuarioController : ControllerBase
    {
        public IUsuarioService _usuarioService;
        public string retorno = "";
        public Usuario user;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("BuscarUsuario")]
        public Usuario BuscarUsuario(Guid id)
        {
            return _usuarioService.BuscarUsuarioPorId(id);
        }
        
        [HttpPost("Login")]
        public bool LoginUsuario(Usuario usuario)
        {
            return _usuarioService.Logar(usuario);
        }

        [HttpPost("CadastrarUsuario")]
        public string CadastrarUsuario(Usuario usuario)
        {

            try
            {
                 retorno = _usuarioService.CadastrarUsuarioService(usuario);

            }
            catch (WePassExceptions error)
            {

                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPost("AtivarUsuario")]
        public string AtivarUsuario(Guid id)
        {
            try
            {
                retorno = _usuarioService.AtivarUsuarioService(id);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }


        [HttpPut("EditarUsuario")]
        public Usuario EditarUsuario(Usuario user)
        {
            try
            {
                user = _usuarioService.EditarUsuario(user);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return user;
        }

        [HttpDelete("DesativarUsuario")]
        public string DesativarUsuario(Guid id)
        {
            try
            {
                retorno = _usuarioService.DesativarUsuarioService(id);
            }
            catch (WePassExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }

    }
}