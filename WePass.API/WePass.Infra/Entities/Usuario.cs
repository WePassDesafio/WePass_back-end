using WePass.Infra.Entities.Base;

namespace WePass.Infra.Entities
{
    public class Usuario : EntityComplexBase
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
