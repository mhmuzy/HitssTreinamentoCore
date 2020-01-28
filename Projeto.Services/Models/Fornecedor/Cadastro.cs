using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models.Fornecedor
{
    public class Cadastro
    {

        [Required(ErrorMessage = "Nome Obrigatorio")]
        [MaxLength(150, ErrorMessage ="O Nome deve conter no Máximo {0} caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome deve conter no mínimo {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CNPJ Obrigatorio")]
        public string Cnpj { get; set; }

    }
}
