using System.Collections.Generic;

namespace PESSOAL.ControleFinanceiro.Utilities
{
    public class ResultDefault<T>
    {
        public List<T> Data { get; set; } = new List<T>();
        public List<string> Messages { get; set; } = new List<string>();
        public bool IsError { get; set; }

    }
}
