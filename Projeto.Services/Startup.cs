using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper.Configuration;
using IConfiguration = AutoMapper.Configuration.IConfiguration;

namespace Projeto.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            DependencyResolver.Register(services, Configuration);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //services.AddSwaggerGen(
            //    swagger =>
            //    {
            //        swagger.SwaggerDoc(
            //            new Info
            //            {
            //                Title = "API de Controle de Produtos",
            //                Version = "v1",
            //                Description = "Esse é o Treino do API Core"
            //            }
            //            );
            //    }
            //    );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            //app.UseSwaggerUI(
            //    swagger =>
            //    {
            //        swagger.SwaggerEndpoint
            //        ("/swagger/v1/swagger.json", "Fornecimento de Produtos");
            //    }
            //    );

            app.UseMvc();
        }
    }
}
