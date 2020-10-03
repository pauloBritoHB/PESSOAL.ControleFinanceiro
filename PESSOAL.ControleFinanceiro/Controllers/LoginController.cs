using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PESSOAL.ControleFinanceiro.MODELS;

namespace PESSOAL.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("Login")]
    public class LoginController : ControllerBase
    {

        private Usuario usuario = new Usuario()
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
            return Ok(usuario);
        }

           
    }
}
