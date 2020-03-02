using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model.Base;

namespace WePass.Domain.Model
{
    public class Usuario : CreateBase
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


    }
}
