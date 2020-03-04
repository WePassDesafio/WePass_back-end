using System.Collections.Generic;
using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Usuario : EntityComplexBase
    {
        public Usuario()
        {
            this.Compras = new List<Compra>();
            this.Eventos = new List<Evento>();
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        // relacionameto com compras
        public IList<Compra> Compras { get; set; }
        
        // relacionamento com eventos
        public IList<Evento> Eventos { get; set; }
    }
}
