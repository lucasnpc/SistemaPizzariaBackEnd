using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class ClienteFidelizado
    {
        [Key]
        public string cpfCliente { get; set; }
        public string nome { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public List<Pedido> pedidos_cliente { get; set; }
    }
}
