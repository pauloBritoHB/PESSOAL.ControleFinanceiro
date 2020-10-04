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

        [HttpPost]
        [Route("Logar")]
        public ActionResult Logar(Usuario user)
        {
            
            if (user.Login == usuario.Login && user.Senha == usuario.Senha)
            {
                return Ok(usuario);
            }
            
           
            return BadRequest("deu merda");
        }

           
    }
}
