using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Venda
    {
        [Key]
        public string idVenda { get; set; }
        public DateTime dataVenda { get; set; }
        public double valorVenda { get; set; }
        public string tipoVenda { get; set; }
        public Comanda idComanda { get; set; }
        public Pedido idPedido { get; set; }
    }
}
