using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contexts;
using WebApplication1.Token;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }


        public static List<Product> myList = new List<Product>()
        {

                new(){Id=1, Name="p111"},
                new(){Id=2, Name="p222"},
                new(){Id=3, Name="p333"},
                new(){Id=4, Name="p444"},
                new(){Id=5, Name="p555"},
                new(){Id=6, Name="p666"},
                new(){Id=7, Name="p777"},
                new(){Id=8, Name="p888"},
                new(){Id=9, Name="p999"},

        
        };

        [HttpPost("Login")]
        public IActionResult Login(LoginDto dto)
        {
            TokenGenerator tokenGenerator = new TokenGenerator();
           var result =  _context.AppUsers.Any(x => x.Email == dto.email && x.Password == dto.password);

            var data =  result ? tokenGenerator.GenerateToken() : "kullanıcı adı yada şifre hatalı";

            return Ok(data);
        }

        [Authorize(Roles ="admin,member")]
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {

            return Ok(myList);  

        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class LoginDto
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
