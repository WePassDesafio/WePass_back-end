using System;
using System.Collections.Generic;
using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Pagamento : EntityComplexBase
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

        // relacionameto com compras
        public IList<Compra> Compras { get; set; }
    }
}
