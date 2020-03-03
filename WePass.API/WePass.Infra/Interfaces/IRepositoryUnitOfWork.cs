using WePass.Domain.Interfaces;

namespace WePass.Infra.Interfaces
{
    public interface IRepositoryUnitOfWork
    {
        IUsuarioRepository Usuario { get; }
        ICompraRepository Compra { get; }
        IEventoRepository Evento { get; }
        IPagamentoRepository Pagamento { get; }
        bool Commit();
    }
}
