using BBShop.App.Extensions;
using BBShop.Application.Common.Interfaces;
using BBShop.Domain.Interfaces;
using BBShop.Domain.Notifications;
using BBShop.Domain.Services;
using BBShop.Infrastructure.Context;
using BBShop.Infrastructure.Repository;
using BBShop.Infrastructure.Services;
using BBShop.WebUI.Services;
using KissLog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace BBShop.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            //Registrar validação do lado do cliente
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ILogger>((context) =>
            {
                return Logger.Factory.Get();
            });

            services.AddScoped<AuditFilter>();


            services.AddScoped<INotificator, Notificator>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();


            return services;
        }
    }
}
