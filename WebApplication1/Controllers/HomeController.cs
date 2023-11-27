using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Token;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet("GetMyToken")]
        public IActionResult GetMyToken()
        {

            //id  şifre
            //email pass
            
            TokenGenerator tokenGenerator = new TokenGenerator();   

            var data =  tokenGenerator.GenerateToken();

            return Ok(data);
        }

        [Authorize]
        [HttpGet("TestToken")]
        public IActionResult TestToken()
        {
            return Ok("giriş başarılı test token");
        }

        [Authorize(Roles = "member")]
        [HttpGet("TestRole")]
        public IActionResult TestRole()
        {
            return Ok("giriş başarılı test role");
        }



    }
}
