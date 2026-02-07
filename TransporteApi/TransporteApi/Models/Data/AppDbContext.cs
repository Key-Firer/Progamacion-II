using Microsoft.EntityFrameworkCore;
using TransporteApi.Controllers;

namespace TransporteApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TransporteOpcion> TransporteOpciones { get; set; }
    }
}
