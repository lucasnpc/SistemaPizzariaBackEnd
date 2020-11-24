using BackEndPizzaria.Context;
using BackEndPizzaria.Models;
using Microsoft.AspNetCore.Mvc;
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

        [Route("get")]
        [HttpGet]
        //public Pizzaria Get()
        //{
        //}

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
