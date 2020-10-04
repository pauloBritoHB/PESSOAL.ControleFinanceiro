using PESSOAL.ControleFinanceiro.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PESSOAL.ControleFinanceiro.MODELS
{
    public class Operacao
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        public TipoOperacaoEnum TipoOperação { get; set; }
        public CatergoriaEnum Cateroria { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }
}
