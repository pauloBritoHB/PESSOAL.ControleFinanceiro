using PESSOAL.ControleFinanceiro.MODELS;
using PESSOAL.ControleFinanceiro.SERVICES.Results;


namespace PESSOAL.ControleFinanceiro.SERVICES.Interfaces
{
     public interface IFinanceiroServices
    {
         PadraoResult<Usuario> Logar(Usuario user);
    }
}
