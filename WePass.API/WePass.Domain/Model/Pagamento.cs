using System;
using WePass.Domain.Model.Base;

namespace WePass.Domain.Model
{
    public class Pagamento : CreateBase
    {
        //pagamento cartao
        public int? numeroCartao { get; set; }
        public DateTime? validadeCartao { get; set; }
        public int? codigoSeguranca { get; set; }




        //pagamento dinheiro
        public int? Dinheiro { get; set; }

    }
}
