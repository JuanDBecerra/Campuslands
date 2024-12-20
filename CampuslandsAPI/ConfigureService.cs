using Campuslands.Interfaces;
using Campuslands.Repositories;
using Campuslands.Services;
using Microsoft.EntityFrameworkCore;

namespace CampuslandsAPI
{
    public class ConfigureService
    {
        private readonly IConfiguration _configuration;

        public ConfigureService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IServiceCollection services)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IMediatorService, MediatorService>();
            services.AddScoped<IClienteService, ClientesService>();
            services.AddScoped<IProductosService, ProductosService>();
            services.AddScoped<IPedidosService, PedidosService>();
        }
    }
}
