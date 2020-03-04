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
    public class CompraService : ICompraService
    {
        #region Atributos

        private readonly IMapper _mapper;
        private readonly IRepositoryUnitOfWork _unitOfWork;

        #endregion

        #region Construtor

        public CompraService(IRepositoryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }

        #endregion

        public string AtivarCompraService(Guid id)
        {
            var desativarCompra = BuscarCompraPorIdService(id);

            if (desativarCompra.Active != true)
            {
                desativarCompra.Active = true;

                _unitOfWork.Compra.Update(desativarCompra);
                _unitOfWork.Commit();
                return Message.MSG_S002;
            }

            return Message.MSG_D003;
        }

        public Compra BuscarCompraPorIdService(Guid Id)
        {
            var compra = _unitOfWork.Compra.Query(a => a.Id == Id);

            if (compra == null)
            {
                throw new WePassExceptions("Usuario invalido");
            }

            return compra;
        }

        public List<Compra> BuscarTodasComprasPorIdService(Compra compra)
        {
            List<Compra> purchase = new List<Compra>();

            purchase = _unitOfWork.Compra.List().OrderBy(x => x.Id).ToList();


            if (purchase == null)
            {
                throw new WePassExceptions("Usuario invalido");
            }

            return purchase;
        }

        public string CadastrarCompraService(Compra compra)
        {
            throw new NotImplementedException();
        }
        //public string CadastrarCompraService(Compra compra)
        //{
        //    var cadastrar = BuscarTodasComprasPorIdService(compra);

        //    bool VerificandoLivro = false;

        //    foreach (var vericicandoCadastro in cadastrar)
        //    {
        //        if (vericicandoCadastro.Id == compra.NomeF)
        //        {
        //            VerificandoLivro = true;
        //        }
        //    }

        //    if (VerificandoLivro == false)
        //    {
        //        _unitOfWork.Autor.Add(autor);
        //        _unitOfWork.Commit();
        //        return Message.MSG_S001;
        //    }
        //    return Message.MSG_S004;
        //}

        public string DesativarCompraService(Guid id)
        {
            var desativarCompra = BuscarCompraPorIdService(id);

            if (desativarCompra.Active != false)
            {
                desativarCompra.Active = false;

                _unitOfWork.Compra.Update(desativarCompra);
                _unitOfWork.Commit();
                return Message.MSG_S002;
            }

            return Message.MSG_D003;
        }

        public Evento EditarCompraService(Compra compra)
        {
            throw new NotImplementedException();
        }

    }
}
