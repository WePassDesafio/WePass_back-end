using System;
using System.Collections.Generic;
using WePass.Domain.Model.Base;

namespace WePass.Domain.Model
{
    public class Pagamento : CreateBase
    {
        public Pagamento()
        {
            this.Compras = new List<Compra>();
        }

        // informar qual forma de pagamento
        public string FormaPagamento { get; set; }

        //pagamento cartao
        public int? numeroCartao { get; set; }
        public DateTime? validadeCartao { get; set; }
        public int? codigoSeguranca { get; set; }

        //pagamento dinheiro
        public int? Dinheiro { get; set; }


        //relacionamento com usuario
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // relacionameto com compras
        public IList<Compra> Compras { get; set; }

    }
}
