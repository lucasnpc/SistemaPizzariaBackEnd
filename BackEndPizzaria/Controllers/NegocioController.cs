using BackEndPizzaria.Context;
using BackEndPizzaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BackEndPizzaria.Controllers
{
    [ApiController]
    [Route("negocios")]
    public class NegocioController: ControllerBase
    {
        private readonly PizzariaContext _context;
        private readonly ILogger<NegocioController> _logger;

        public NegocioController(ILogger<NegocioController> logger, PizzariaContext context)
        {
            _context = context;
            _logger = logger;
        }

        [Route("post")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Negocio pizzaria)
        {
            _logger.LogInformation(1002, "Post {pizzaria} da request", pizzaria);
            _context.pizzarias.Add(pizzaria);
            await _context.SaveChangesAsync();
            return Ok(200);
        }
    }
}
