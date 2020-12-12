using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Pedido
    {
        [Key]
        public int id_pedido { get; set; }
        public List<Itens> itens { get; set; }
        public string rua_entrega { get; set; }
        public string numero_entrega { get; set; }
        public string bairro_entrega { get; set; }
        public string cidade_entrega { get; set; }
        public ClienteFidelizado clienteFidelizado { get; set; }
        public double valor_conta { get; set; }
    }
}
