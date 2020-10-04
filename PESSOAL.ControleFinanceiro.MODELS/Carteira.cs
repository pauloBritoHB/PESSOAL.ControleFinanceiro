using System;
using System.Collections.Generic;
using System.Text;

namespace PESSOAL.ControleFinanceiro.MODELS
{
    public class Carteira
    {
        public int Id { get; set; }
        public double Saldo { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        public ICollection<Operacao> Operações { get; set; }

        public ICollection<A_Pagar> ContasAPagar { get; set; }
    }
}
