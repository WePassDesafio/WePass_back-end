using System;
using System.Collections.Generic;
using System.Text;
using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Evento : EntityComplexBase
    {
        public Evento()
        {
            this.Compras = new List<Compra>();
        }

        public string NomeEvento { get; set; }
        public string Categoria { get; set; }
        public double ValorIngresso { get; set; }
        public DateTime DataEvento { get; set; }
        public int QuantidadeIngresso { get; set; }

        //relacionamento com usuario
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // relacionameto com compras
        public IList<Compra> Compras { get; set; }

    }
}
