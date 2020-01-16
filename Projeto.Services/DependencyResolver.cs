using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper.Configuration;
using Projeto.Services.Contracts;

namespace Projeto.Services
{
    public class DependencyResolver
    {
        public static void Register
            (IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient
                <IProdutoAplicationServices, Projeto.Services.Services.Produto.ApplicationServices>();
            services.AddTransient
                <IFornecedorApplicationServices, Projeto.Services.Services.Fornecedor.ApplicationServices>();

            services.AddTransient
                <IProdutoAplicationServices, ProdutoDomainService>();
            services.AddTransient
                <IFornecedorApplicationServices, FornecedorDomainService>();

            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddTransient<IFornecedorRepository, FornecedorRepository>();

            services.AddDbContext<DataContext>
                (options => options.UseSqlServer
                (Configurations.GetConnectionString("HitssTreinamentoCore")));
        }
    }
}
