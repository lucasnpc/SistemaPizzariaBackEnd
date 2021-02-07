﻿using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Produto
    {
        [Key]
        public string idProduto { get; set; }
        public string descricao { get; set; }
        public double estoqueMinimo { get; set; }
        public double estoqueMaximo { get; set; }
        public double quantidadeAtual { get; set; }
        public double valorCusto { get; set; }
        public Fornecedor idFornecedor { get; set; }
        public Itens idItem { get; set; }
    }
}
