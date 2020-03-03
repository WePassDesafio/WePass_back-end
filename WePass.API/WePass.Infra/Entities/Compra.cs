using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Compra : EntityComplexBase
    {
        public int QuantidadeIngresso { get; set; }
        //public Guid UsuarioId { get; set; }
        //public Guid EventoId { get; set; }
        //public Guid PagamentoId { get; set; }
    }
}
