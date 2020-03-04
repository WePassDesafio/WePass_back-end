using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model.Base;

namespace WePass.Domain.Model
{
    public class Compra : CreateBase
    {
        public int QuantidadeIngresso { get; set; }
        public int Vezes { get; set; }

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
