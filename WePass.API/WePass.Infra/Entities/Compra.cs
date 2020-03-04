using System;
using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Compra : EntityComplexBase
    {
        public int QuantidadeIngresso { get; set; }

        //relacionamento com usuario
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        //relacionamento com evento
        public Guid EventoId { get; set; }
        public Evento Evento { get; set; }

        //relacionamento com pagamento
        public Guid PagamentoId { get; set; }
        public Pagamento Pagamento { get; set; }


    }
}
