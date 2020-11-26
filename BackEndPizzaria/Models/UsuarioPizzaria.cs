using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndPizzaria.Models
{
    public class UsuarioPizzaria
    {
        [Key]
        public string userId { get; set; }
        public string userSenha { get; set; }
        public Pizzaria pizzaria { get; set; }
    }
}
