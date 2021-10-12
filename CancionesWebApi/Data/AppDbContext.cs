using CancionesWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CancionesWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cancion> Cancion { get; set; }
    }
   
}
