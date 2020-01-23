using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper.Configuration;
using Projeto.Services.Contracts;
using Microsoft.Extensions.Configuration;
using IConfiguration = AutoMapper.Configuration.IConfiguration;
using Projeto.Services.Domain.Services;
using Projeto.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Projeto.Services
{
    public class DependencyResolver
    {
        public static object Configuration { get; private set; }

        public static void Register
            (IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient
                <IProdutoAplicationServices, Projeto.Services.Services.Produto.ApplicationServices>();
            services.AddTransient
                <IFornecedorApplicationServices, Projeto.Services.Services.Fornecedor.ApplicationServices>();

            //services.AddTransient
            //    <IProdutoAplicationServices, ProdutoDomainService>();
            //services.AddTransient
            //    <IFornecedorApplicationServices, FornecedorDomainServices>();

            //services.AddTransient<IProdutoRepository, ProdutoRepository>();

            //services.AddTransient<IFornecedorRepository, FornecedorRepository>();

            //services.AddDbContext<DataContext>
            //    (options => options.UseSqlServer
            //    (connectionString: Configuration.GetConnectionString("HitssTreinamentoCore")));
        }

        internal static void Register(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            //throw new NotImplementedException();
            //DependencyResolver.Register(services, Configuration);

        }

        private static void Register(IServiceCollection services, object configuration)
        {
            throw new NotImplementedException();
        }
    }
}
