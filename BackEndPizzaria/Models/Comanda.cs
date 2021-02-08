using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Comanda
    {
        [Key]
        public int idComanda { get; set; }
        public string numeroMesa { get; set; }
        [Key]
        public Itens itens { get; set; }
        public double valorConta { get; set; }
    }
}
