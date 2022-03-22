using Microsoft.EntityFrameworkCore;
using ProEventos.Model;

namespace ProEventos.DAO
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Evento> Eventos { get; set; }
        
        
    }
}