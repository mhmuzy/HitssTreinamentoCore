using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Services.Models.Fornecedor;

namespace Projeto.Services.Contracts
{
    public interface IFornecedorApplicationServices 
        : IDisposable
    {

        void Inserir(Cadastro cadastro);

        void Atualizar(Editar editar);

        void Excluir(int id);

        List<Consultar> consultars();

        Consultar GetConsultarId(int id);
        //string ObterporId(int id);

    }
}
