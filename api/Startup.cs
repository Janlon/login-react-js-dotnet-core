using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using apiLogin.Data;
using apiLogin.Models;
using apiLogin.Security;
using apiLogin.Business;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace apiLogin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configurando o acesso a dados de produtos
            services.AddDbContext<CatalogoDbContext>(options =>
                options.UseInMemoryDatabase("InMemoryDatabase"));
            services.AddScoped<ProdutoService>();

            // Configurando o uso da classe de contexto para
            // acesso às tabelas do ASP.NET Identity Core
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("InMemoryDatabase"));

            // Ativando a utilização do ASP.NET Identity, a fim de
            // permitir a recuperação de seus objetos via injeção de
            // dependências
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Configurando a dependência para a classe de validação
            // de credenciais e geração de tokens
            services.AddScoped<AccessManager>();

            var signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                Configuration.GetSection("TokenConfigurations"))
                    .Configure(tokenConfigurations);
            services.AddSingleton(tokenConfigurations);

            // Aciona a extensão que irá configurar o uso de
            // autenticação e autorização via tokens
            services.AddJwtSecurity(signingConfigurations, tokenConfigurations);
            //  services.AddCors(option => {
            //     option.AddPolicy("AllowSpecificOrigin", policy => policy.WithOrigins("http://localhost:3000"));
            //     option.AddPolicy("AllowGetMethod", policy => policy.WithMethods("POST"));
            // });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            // services.Configure<MvcOptions>(options => {
            //     options.Filters.Add(new CorsAuthorizationFilterFactory("AllowSpecificOrigin"));
            // });

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            // Criação de estruturas, usuários e permissões
            // na base do ASP.NET Identity Core (caso ainda não
            // existam)
            new IdentityInitializer(context, userManager, roleManager).Initialize();

            // app.UseCors("AllowSpecificOrigin");
            // app.UseCors(option => option.WithOrigins("http://localhost:3000", "https://localhost:3000")); 
            // app.UseCors(option => option.AllowAnyOrigin());
            // app.UseCors(option => option.WithMethods("GET", "POST")); 
            // app.UseCors(option => option.AllowAnyMethod()); 
            // app.UseCors(option => option.WithHeaders("accept", "content-type", "origin")); 
            // app.UseCors(option => option.AllowAnyHeader());  
            // app.UseCors(option => option.AllowCredentials());   
            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}