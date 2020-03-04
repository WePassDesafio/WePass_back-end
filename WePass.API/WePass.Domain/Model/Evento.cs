using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model.Base;

namespace WePass.Domain.Model
{
    public class Evento : CreateBase
    {
        public Evento()
        {
            this.Compras = new List<Compra>();
        }

        public string NomeEvento { get; set; }
        public string Categoria { get; set; }
        public string ValorIngresso { get; set; }
        public DateTime DataEvento { get; set; }
        public int QuantidadeIngresso { get; set; }

        //relacionamento com usuario
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // relacionameto com compras
        public IList<Compra> Compras { get; set; }
    }
}
