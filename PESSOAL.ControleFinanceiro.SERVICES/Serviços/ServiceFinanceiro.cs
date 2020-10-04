using PESSOAL.ControleFinanceiro.CONTEXT;
using PESSOAL.ControleFinanceiro.MODELS;
using PESSOAL.ControleFinanceiro.SERVICES.Interfaces;
using PESSOAL.ControleFinanceiro.SERVICES.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PESSOAL.ControleFinanceiro.SERVICES.Serviços
{
    public class ServiceFinanceiro : IFinanceiroServices
    {

        private BancoContext db;

        public ServiceFinanceiro(BancoContext bancoContext)
        {
            db = bancoContext;
        }


        public PadraoResult<Usuario> Logar(Usuario user)
        {
            var result = new PadraoResult<Usuario>();
            var usuario = db.Usuarios.Where(x => x.Login == user.Login && x.Senha == user.Senha).FirstOrDefault();
            if (usuario == null)
            {
                result.Data = null;
                result.IsError = true;
                result.Message.Add("Usuario inválido");
                return result;
            }
            result.Data.Add(usuario);
            result.IsError = false;
            result.Message.Add("ok");

            return result;
        }
    }
}
