using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model.Base;

namespace WePass.Domain.Model
{
    public class Usuario : CreateBase
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
