﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    public class Remedio
    {        
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Nome do Remédio")]
        [Required(ErrorMessage = "Informe um nome para o remédio.")]
        public string Nome { get; set; }
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "Informe uma quantidade.")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Informe um valor.")]
        [Display(Name = "Preço")]
        public decimal? Preco { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Validade { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
