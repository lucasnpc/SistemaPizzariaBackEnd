using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndPizzaria.Models
{
    public class Negocio
    {
        [Key]
        public string idNegocio { get; set; }
        public string nomeNegocio { get; set; }
        public string ruaNegocio { get; set; }
        public string numeroNegocio { get; set; }
        public string bairroNegocio { get; set; }
        public string cidadeNegocio { get; set; }
        public string estadoNegocio { get; set; }
        public List<Usuario> usersNegocio { get; set; }
    }
}
