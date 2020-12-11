using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndPizzaria.Models
{
    public class Itens
    {
        [Key]
        public int id_item { get; set; }
        public double preco { get; set; }
        public string descricao { get; set; }
        public List<Produto> produtos { get; set; }
    }
}
