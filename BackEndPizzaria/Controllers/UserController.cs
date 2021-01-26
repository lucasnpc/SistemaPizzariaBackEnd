using BackEndPizzaria.Context;
using BackEndPizzaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace BackEndPizzaria.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController: ControllerBase
    {
        private readonly PizzariaContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, PizzariaContext context)
        {
            _context = context;
            _logger = logger;
        }


        [Route("authUser")]
        [HttpPost]
        public bool AuthUser([FromBody] Usuario usuario)
        {
            _logger.LogInformation(1002, "Post user={usuario} senha={senha}", usuario.userId, usuario.userSenha);
            var user = (from u in _context.users
                        where u.userId == usuario.userId && u.userSenha == usuario.userSenha
                        select u).Single();
            if (user == null)
                return false;

            return true;
        }

    }
}
