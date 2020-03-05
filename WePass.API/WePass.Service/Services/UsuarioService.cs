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
    public class UsuarioService : IUsuarioService
    {
        #region Atributos

        private readonly IMapper _mapper;
        private readonly IRepositoryUnitOfWork _unitOfWork;

        #endregion

        #region Construtor

        public UsuarioService(IRepositoryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }

        #endregion




        public string AtivarUsuarioService(Guid id)
        {
            var desativarUsuario = BuscarUsuarioPorId(id);

            if (desativarUsuario.Active != true)
            {
                desativarUsuario.Active = true;

                _unitOfWork.Usuario.Update(desativarUsuario);
                _unitOfWork.Commit();
                return Message.MSG_S002;
            }

            return Message.MSG_S003;
        }

        public List<Usuario> BuscarTodosUsuarioPorId(Usuario usuario)
        {
            List<Usuario> user = new List<Usuario>();

            user = _unitOfWork.Usuario.List().OrderBy(x => x.Nome).ToList();


            if (user == null)
            {
                throw new WePassExceptions("Usuario invalido");
            }

            return user;
        }

        // metodo também utilizado para verificação
        public Usuario BuscarUsuarioPorId(Guid id)
        {
            var usuario = _unitOfWork.Usuario.Query(a => a.Id == id);

            if (usuario == null)
            {
                throw new WePassExceptions("Usuario invalido");
            }

            return usuario;
        }

        public string CadastrarUsuarioService(Usuario usuario)
        {
            var Cadastrar = BuscarTodosUsuarioPorId(usuario);

            bool verificandoUsuario = false;

            foreach (var user in Cadastrar)
            {
                if (user.Nome == usuario.Nome)
                {
                    verificandoUsuario = true;
                }
            }

            if (verificandoUsuario == false)
            {
                _unitOfWork.Usuario.Add(usuario);
                _unitOfWork.Commit();
                return Message.MSG_S001;
            }
            return Message.MSG_S004;
        }


        // deleção logica
        public string DesativarUsuarioService(Guid id)
        {
            var desativarUsuario = BuscarUsuarioPorId(id);

            if (desativarUsuario.Active != false)
            {
                desativarUsuario.Active = false;

                _unitOfWork.Usuario.Update(desativarUsuario);
                _unitOfWork.Commit();
                return Message.MSG_D001;
            }

            return Message.MSG_D003;
        }

        public Usuario EditarUsuario(Usuario usuario)
        {
            var editarusuario = BuscarUsuarioPorId(usuario.Id);

            if (editarusuario != null)
            {
                _unitOfWork.Usuario.Update(usuario);
                _unitOfWork.Commit();
            }

            return usuario;
        }

        public bool Logar(Usuario usuario)
        {
            bool LogandoUsuario = false;

            var verificandoLogin = _unitOfWork.Usuario.Query(l => l.Login == usuario.Login);
            var verificandoSenha = _unitOfWork.Usuario.Query(s => s.Senha == usuario.Senha);

            if (verificandoLogin != null && verificandoSenha != null)
            {
                LogandoUsuario = true;
                return LogandoUsuario;
            }
            return LogandoUsuario;
        }
    }
}
