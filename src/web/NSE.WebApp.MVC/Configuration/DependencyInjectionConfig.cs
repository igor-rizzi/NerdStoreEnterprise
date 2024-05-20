using NSE.WebApp.MVC.Extensions;
using NSE.WebApp.MVC.Interfaces.Services.Autenticacao;
using NSE.WebApp.MVC.Services.Autenticacao;

namespace NSE.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
