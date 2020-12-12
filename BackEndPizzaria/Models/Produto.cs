using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Produto
    {
        [Key]
        public string id_produto { get; set; }
        public string descricao { get; set; }
        public double estoque_minimo { get; set; }
        public double estoque_maximo { get; set; }
        public double quantidade_atual { get; set; }
        public double valor_custo { get; set; }
        public Fornecedor id_fornecedor { get; set; }
        public Itens id_item { get; set; }
    }
}
