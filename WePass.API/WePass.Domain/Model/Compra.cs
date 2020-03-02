using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model.Base;

namespace WePass.Domain.Model
{
    public class Compra : CreateBase
    {
        public int QuantidadeIngresso { get; set; }
        //public Guid UsuarioId { get; set; }
        //public Guid EventoId { get; set; }
        //public Guid PagamentoId { get; set; }
    }
}
