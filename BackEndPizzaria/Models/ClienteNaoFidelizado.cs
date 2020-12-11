using BackEndPizzaria.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndPizzaria.Models
{
    public class ClienteNaoFidelizado
    {

        [Key]
        public string IdCliente { get; set; }
        public string nome { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
    }
}
