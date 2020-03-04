using System;
using System.Collections.Generic;
using WePass.Domain.Model;

namespace WePass.Service.Interfaces
{
    public interface IUsuarioService
    {
        //Create
        string CadastrarUsuarioService(Usuario usuario);

        //Read
        Usuario BuscarUsuarioPorId(Guid id);
        List<Usuario> BuscarTodosEventorPorId(Usuario usuario);

        //Update
        Usuario EditarUsuario(Usuario usuario);
        string AtivarUsuarioService(Guid id);

        //Delete logico
        string DesativarAutorService(Guid id);
    }
}
