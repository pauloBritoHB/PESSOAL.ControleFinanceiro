using Microsoft.AspNetCore.Mvc;
using PESSOAL.ControleFinanceiro.MODELS;
using PESSOAL.ControleFinanceiro.SERVICES.Interfaces;
using PESSOAL.ControleFinanceiro.SERVICES.Results;

namespace PESSOAL.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Login")]
    public class LoginController : ControllerBase
    {

        private IFinanceiroServices service;

        public LoginController(IFinanceiroServices srvc)
        {
            service = srvc;
        }

        [HttpPost]
        [Route("Logar")]
        public PadraoResult<Usuario> Logar(Usuario user)
        {
            var result = service.Logar(user);
            return result;
        }


    }
}
