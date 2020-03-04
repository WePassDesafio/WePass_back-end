using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WePass.Domain.Model;
using WePass.Service.Interfaces;

namespace WePass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("BuscarUsuario")]
        public Usuario BuscarUsuario(Guid id)
        {
            return _usuarioService.BuscarUsuarioPorId(id);
        }






    }
}