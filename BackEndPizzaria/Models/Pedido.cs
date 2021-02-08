using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Pedido
    {
        [Key]
        public int idPedido { get; set; }
        [Key]
        public Itens itens { get; set; }
        public string ruaEntrega { get; set; }
        public string numeroEntrega { get; set; }
        public string bairroEntrega { get; set; }
        public string cidadeEntrega { get; set; }
        public ClienteFidelizado clienteFidelizado { get; set; }
        public double valorConta { get; set; }
    }
}
