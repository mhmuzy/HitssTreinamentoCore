using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models.Produtos
{
    public class Cadastro
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preço Obrigatório")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Quantidade Obrigatório")]
        public int Quantidade { get; set; }

    }
}
