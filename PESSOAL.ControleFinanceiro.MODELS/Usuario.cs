using System;
using System.Collections.Generic;

namespace PESSOAL.ControleFinanceiro.MODELS
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdCarteira { get; set; }
        public ICollection<Carteira> Carteiras { get; set; }
    }
}
