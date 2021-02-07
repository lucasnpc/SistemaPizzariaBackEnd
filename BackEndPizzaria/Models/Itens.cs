﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Itens
    {
        [Key]
        public int id_item { get; set; }
        public double preco { get; set; }
        public string descricao { get; set; }
        public List<Produto> ingredientes { get; set; }
    }
}
