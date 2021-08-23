using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    public class UsoDiario
    {        
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Nome do item")]
        [Required(ErrorMessage = "Informe um nome para o item.")]
        public string Nome { get; set; }
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "Informe uma quantidade.")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Informe um valor.")]
        [Display(Name = "Preço")]
        public decimal? Preco { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Validade { get; set; }

        
    }
}
