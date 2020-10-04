using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PESSOAL.ControleFinanceiro.CONTEXT;
using PESSOAL.ControleFinanceiro.SERVICES.Interfaces;
using PESSOAL.ControleFinanceiro.SERVICES.Serviços;

namespace PESSOAL.ControleFinanceiro.SERVICES
{
    public static class InjectionDependencia
    {
        public static void Injetar(this IServiceCollection services, string connection)
        {
            services.AddDbContext<BancoContext>(options => options.UseSqlServer(connection));
            services.AddTransient<IFinanceiroServices, ServiceFinanceiro>();
        }

    }
}
