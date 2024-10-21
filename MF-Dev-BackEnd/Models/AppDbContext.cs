using Microsoft.EntityFrameworkCore;

namespace MF_Dev_BackEnd.Models
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
