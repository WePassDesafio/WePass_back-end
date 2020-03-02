using System;
using System.Collections.Generic;
using System.Text;

namespace WePass.Domain.Model
{
    public class Evento
    {
        public string NomeEvento { get; set; }
        public string Categoria { get; set; }
        public string ValorIngresso { get; set; }
        public DateTime DataEvento { get; set; }
        public int quantidadeIngresso { get; set; }
    }
}
