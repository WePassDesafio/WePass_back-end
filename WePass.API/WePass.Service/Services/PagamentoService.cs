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
    public class PagamentoService : IPagamentoService
    {
        #region Atributos

        private readonly IMapper _mapper;
        private readonly IRepositoryUnitOfWork _unitOfWork;

        #endregion

        #region Construtor

        public PagamentoService(IRepositoryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }

        public string AtivarPagamentoService(Guid id)
        {
            var desativarUsuario = BuscarPagamentoPorId(id);

            if (desativarUsuario.Active != true)
            {
                desativarUsuario.Active = true;

                _unitOfWork.Pagamento.Update(desativarUsuario);
                _unitOfWork.Commit();
                return Message.MSG_S002;
            }

            return Message.MSG_D003;
        }

        public Pagamento BuscarPagamentoPorId(Guid id)
        {
            var usuario = _unitOfWork.Pagamento.Query(a => a.Id == id);

            if (usuario == null)
            {
                throw new WePassExceptions("Usuario invalido");
            }

            return usuario;
        }

        public List<Pagamento> BuscarTodosPagamentosPorId(Pagamento pagamento)
        {
            List<Pagamento> pay = new List<Pagamento>();

            pay = _unitOfWork.Pagamento.List().OrderBy(x => x.FormaPagamento).ToList();


            if (pay == null)
            {
                throw new WePassExceptions("Pagamento invalido");
            }

            return pay;
        }

        public string CadastrarPagamentoService(Pagamento pagamento)
        {
            bool verificandoPagamento = false;

            if (verificandoPagamento == false)
            {
                _unitOfWork.Pagamento.Add(pagamento);
                _unitOfWork.Commit();
                return Message.MSG_S001;
            }
            return Message.MSG_S004;
        }

        public string DesativarPagamentoService(Pagamento pagamento)
        {
            var desativarPagamento = BuscarPagamentoPorId(pagamento.Id);

            if (desativarPagamento.Active != false)
            {
                desativarPagamento.Active = false;

                _unitOfWork.Pagamento.Update(desativarPagamento);
                _unitOfWork.Commit();
                return Message.MSG_S002;
            }

            return Message.MSG_D003;
        }

        public Pagamento EditarPagamento(Pagamento pagamento)
        {
            var editarusuario = BuscarPagamentoPorId(pagamento.Id);

            if (editarusuario != null)
            {
                _unitOfWork.Pagamento.Update(pagamento);
                _unitOfWork.Commit();
            }

            return pagamento;
        }
        #endregion
    }
}
