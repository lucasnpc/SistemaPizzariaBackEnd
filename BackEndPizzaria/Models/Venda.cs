using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndPizzaria.Models
{
    public class Venda
    {
        [Key]
        public string id_venda { get; set; }
        public DateTime data_venda { get; set; }
        public double valor_venda { get; set; }
        public List<Itens> itens_vendidos { get; set; }
        public string tipo_venda { get; set; }
        public Comanda idComanda { get; set; }
        public Pedido idPedido { get; set; }
    }
}
