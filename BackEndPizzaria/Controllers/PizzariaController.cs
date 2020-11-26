using BackEndPizzaria.Context;
using BackEndPizzaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndPizzaria.Controllers
{
    [ApiController]
    [Route("pizzarias")]
    public class PizzariaController: ControllerBase
    {
        private readonly PizzariaContext _context;
        private readonly ILogger<PizzariaController> _logger;

        public PizzariaController(ILogger<PizzariaController> logger, PizzariaContext context)
        {
            _context = context;
            _logger = logger;
        }

        [Route("authUser")]
        [HttpPost]
        public Boolean AuthUser([FromBody] UsuarioPizzaria usuario)
        {
            _logger.LogInformation(1002, "Post user={usuario} senha={senha}", usuario.userId, usuario.userSenha);
            var userAuth = _context.users.Find(usuario.userId);
            if (userAuth != null)
            {
                return true;
            }
            else
                return false;
        }

        [Route("post")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pizzaria pizzaria)
        {
            _logger.LogInformation(1002, "Post {pizzaria} da request", pizzaria);
            _context.pizzarias.Add(pizzaria);
            await _context.SaveChangesAsync();
            return Ok(200);
        }
    }
}
