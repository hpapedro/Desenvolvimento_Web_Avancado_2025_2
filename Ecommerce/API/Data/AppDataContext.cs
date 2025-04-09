using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions options) : 
        base(options) { }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Produto> Produtos {get; set;}

}
