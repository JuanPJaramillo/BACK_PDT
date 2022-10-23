using PDT.CORE.Interfaces;
using PDT.INFRASTRUCTURE.Repositorios;

namespace Servicios.Api.Resolvers
{
    public static class PdtResolvers
    {
        public static void ServiciosResolversAplications(this IServiceCollection services)
        {
            services.AddTransient<IFlightRepository, FlightRepository>();
            services.AddTransient<IDetailsFlightRepository, DetailsFlightRepository>();



           
        }
    }
}
