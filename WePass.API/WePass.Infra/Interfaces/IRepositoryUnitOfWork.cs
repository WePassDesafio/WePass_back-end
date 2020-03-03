using WePass.Domain.Interfaces;

namespace WePass.Infra.Interfaces
{
    interface IRepositoryUnitOfWork
    {
        IUsuarioRepository Usuario { get; }
        ICartaoRepository Cartao { get; }
        IEventoRepository Evento { get; }
        IPagamentoRepository Pagamento { get; }
        bool Commit();
    }
}
