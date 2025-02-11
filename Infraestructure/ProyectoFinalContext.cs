using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class ProyectoFinalContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=L-Lenovo1-SP\\SqlExpress2022;" +
                                                            "Database=ProyectoFinalDB;User Id=UserSQL;Password=123456;" +
                                                            "Trust Server Certificate=True");
        }

    }
}
