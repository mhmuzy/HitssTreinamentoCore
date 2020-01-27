using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Services.Models.Produtos;

namespace Projeto.Services.Contracts
{
    public interface IProdutoAplicationServices 
        : IDisposable
    {

        void Inserir(Cadastro cadastro);

        void Atualizar(Editar editar);

        void Excluir(int id);

        List<Consultar> consultars();

        Consultar ConsultarPorId(int id);

    }
}
