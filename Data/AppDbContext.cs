using Microsoft.EntityFrameworkCore;
using CasaMateriaisConstrucao.Models;

namespace CasaMateriaisConstrucao.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}