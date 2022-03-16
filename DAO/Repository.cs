using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Model;

namespace ProEventos.DAO
{
    public class Repository : IRepository    
    {
        private readonly DataContext _context;

        public Repository (DataContext context){
            _context = context;
        }
        public async Task<Evento[]> GetAllEventos(){

            IQueryable<Evento> query = _context.Eventos;
            query = query.AsNoTracking().OrderBy(x => x.DataEvento);
            return await query.ToArrayAsync();

        }
    }
}