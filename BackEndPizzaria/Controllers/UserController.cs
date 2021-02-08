using BackEndPizzaria.Context;
using BackEndPizzaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndPizzaria.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController: ControllerBase
    {
        private readonly RestaurantePizzariaContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, RestaurantePizzariaContext context)
        {
            _context = context;
            _logger = logger;
        }


        [Route("authUser")]
        [HttpPost]
        public async Task<IActionResult> AuthUser([FromBody] Usuario usuario)
        {
            _logger.LogInformation(1002, "Post user={usuario} senha={senha}", usuario.userId, usuario.userSenha);
            var user = (from u in _context.users
                        where u.userId == usuario.userId && u.userSenha == usuario.userSenha
                        select u).Single();
            if (user == null)
                return NotFound(404);

            return Ok(200);
        }

    }
}
