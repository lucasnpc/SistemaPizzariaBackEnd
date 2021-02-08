using BackEndPizzaria.Context;
using BackEndPizzaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace BackEndPizzaria.Controllers
{
    [ApiController]
    [Route("itens")]
    public class ItensController: ControllerBase
    {
        private readonly RestaurantePizzariaContext _context;
        private readonly ILogger<ItensController> _logger;

        public ItensController(ILogger<ItensController> logger, RestaurantePizzariaContext context) {
            _context = context;
            _logger = logger;
        }

        [Route("getItemCount")]
        [HttpGet]
        public int GetItensCount() {
            var itens = (from i in _context.itensCardapio select i).Count();
            return itens;
        }

        [Route("getItem")]
        [HttpGet]
        public List<Itens> Get()
        {
            var itens = (from i in _context.itensCardapio select i).ToList();
            _logger.LogInformation(1002, "Metodo chamado item = {item}", itens);
            return itens;
        }

        [Route("postItem")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Itens item)
        {
            _logger.LogInformation(1002, "Post item={descricao} preco={preco}", item.descricao, item.preco);
            _context.itensCardapio.Add(item);
            await _context.SaveChangesAsync();
            return Ok(200);
        }
    }
}
