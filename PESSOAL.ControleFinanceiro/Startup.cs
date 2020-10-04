using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PESSOAL.ControleFinanceiro.SERVICES;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace PESSOAL.ControleFinanceiro
{
    public class Startup
    {

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Angular
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //para funcionar Angular
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:8100/tabs/tab1",
                                                          "http://www.contoso.com")
                                                                    .AllowAnyOrigin()
                                                                    .AllowAnyHeader()
                                                                    .AllowAnyMethod();
                                  });
            });
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------

            services.AddControllers();
            

            //SWAGGER----------------------------------
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Projeto Pessoal Controle Financeiro",
                    Version = "v1",
                });
            });
            //------------------------------------------

            services.Injetar(Configuration.GetConnectionString("DefaultConnection"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();


            //para funcionar Angular
            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //SWAGGER----------------------------------
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1 HBSIS CRUD Pessoa Fisica - PADAWAN");
                c.DocExpansion(DocExpansion.None);
            });
            //------------------------------------------
        }
    }
}
