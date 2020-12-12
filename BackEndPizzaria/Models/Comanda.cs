using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Comanda
    {
        [Key]
        public int id_comanda { get; set; }
        public string numero_mesa { get; set; }
        public List<Itens> itens { get; set; }
        public double valor_conta { get; set; }
    }
}
