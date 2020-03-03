using System;
using System.Collections.Generic;
using System.Text;
using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Evento : EntityComplexBase
    {
        public string NomeEvento { get; set; }
        public string Categoria { get; set; }
        public string ValorIngresso { get; set; }
        public DateTime DataEvento { get; set; }
        public int quantidadeIngresso { get; set; }
    }
}
