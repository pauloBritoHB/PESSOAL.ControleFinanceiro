using Microsoft.AspNetCore.Mvc;
using PESSOAL.ControleFinanceiro.MODELS;
using PESSOAL.ControleFinanceiro.Utilities;

namespace PESSOAL.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Login")]
    public class LoginController : ControllerBase
    {

        public Usuario usuario = new Usuario()
        {
            Id = 1,
            Nome = "Paulo",
            Login = "aaaa",
            Senha= "aaaa"
        };


        public LoginController()
        {
            
        }

        [HttpGet]
        public ActionResult Get()
        {  

            return Ok("logado");
        }

        [HttpGet]
        [Route("Logar")]
        public ActionResult Logar()
        {
            var result = new ResultDefault<Usuario>();

            result.Data.Add(usuario);
            result.IsError = false;
            result.Messages.Add("Ok");
           
            return Ok(result);
        }

           
    }
}
