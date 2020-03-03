using System;
using System.Collections.Generic;
using System.Text;
using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Pagamento : EntityComplexBase
    {
        //pagamento cartao
        public int numeroCartao { get; set; }
        public DateTime validadeCartao { get; set; }
        public int codigoSeguranca { get; set; }

        //pagamento dinheiro
        public int Dinheiro { get; set; }
    }
}
