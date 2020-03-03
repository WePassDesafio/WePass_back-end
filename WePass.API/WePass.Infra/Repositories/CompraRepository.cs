using AutoMapper;
using WePass.Domain.Interfaces;
using WePass.Infra.Context;
using WePass.Infra.Entities;
using WePass.Infra.Repositories.Base;

namespace WePass.Infra.Repositories
{
    public class CompraRepository : RepositoryBase<Domain.Model.Compra, Compra>, ICompraRepository
    {

        #region Atributos

        private IMapper _mapper;

        #endregion

        #region Construtor

        public CompraRepository(WePassContext context) : base(context)
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
