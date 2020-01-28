using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models.Produtos
{
    public class Editar
    {

        [Required(ErrorMessage = "Nome Obrigatório")]
        [MaxLength(150, ErrorMessage = "O Nome deve conter no máximo {0} caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome deve conter no mínimo {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preço Obrigatório")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Quantidade Obrigatório")]
        public int Quantidade { get; set; }

    }
}
