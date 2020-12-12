﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Pizzaria
    {
        [Key]
        public string idPizzaria { get; set; }
        public string nomePizzaria { get; set; }
        public string ruaPizzaria { get; set; }
        public string numeroPizzaria { get; set; }
        public string bairroPizzaria { get; set; }
        public string cidadePizzaria { get; set; }
        public string estadoPizzaria { get; set; }
        public List<Usuario> usersPizzaria { get; set; }
    }
}
