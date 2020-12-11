using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class ClienteFidelizado
    {
        [Key]
        public string cpfCliente { get; set; }
        public string nome { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
    }
}
