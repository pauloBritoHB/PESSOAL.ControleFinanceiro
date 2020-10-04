using PESSOAL.ControleFinanceiro.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PESSOAL.ControleFinanceiro.MODELS
{
    public class A_Pagar
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        public CatergoriaEnum Categoria { get; set; }
        public StatusA_pagar Status { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
    }
}
