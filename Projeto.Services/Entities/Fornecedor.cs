using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Entities
{
    public class Fornecedores
    {

        public int IdFornecedor { get; set; }

        public string Nome { get; set; }

        public string Cnpj { get; set; }

        public List<Produtos> Produtos { get; set; }

    }
}
