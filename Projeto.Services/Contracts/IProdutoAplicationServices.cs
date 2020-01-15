using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Services.Contracts
{
    public interface IProdutoAplicationServices :IDisposable
    {
        void Inserir();
    }
}
