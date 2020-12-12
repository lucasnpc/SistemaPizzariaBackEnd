using System;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class ContasAPagar
    {
        [Key]
        public int id_conta { get; set; }
        public bool eh_fixa { get; set; }
        public string descricao { get; set; }
        public DateTime data_pagamento { get; set; }
        public double valor { get; set; }
        public string tipo_servico { get; set; }
    }
}
