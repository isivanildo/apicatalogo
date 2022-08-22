using Microsoft.EntityFrameworkCore;
using APICatalogo.Models;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        DbSet<Categoria>? Categorias { get; set; }
        DbSet<Produto>? Produtos { get; set; }
    }
}
