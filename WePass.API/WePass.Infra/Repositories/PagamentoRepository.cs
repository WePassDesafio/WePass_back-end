using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Interfaces;
using WePass.Infra.Context;
using WePass.Infra.Entities;
using WePass.Infra.Repositories.Base;

namespace WePass.Infra.Repositories
{
    public class PagamentoRepository : RepositoryBase<Domain.Model.Pagamento, Pagamento>, IPagamentoRepository
    {

        #region Atributos

        private IMapper _mapper;

        #endregion

        #region Construtor

        public PagamentoRepository(WePassContext context) : base(context)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfile));
            });
            _mapper = config.CreateMapper();
        }

        #endregion
    }
}
