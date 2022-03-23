using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.DAO
{
    public class Repository : IRepository    
    {
        private readonly ProEventosContext _context;

        public Repository ( ProEventosContext context){
            _context = context;
        }
        public async Task<Evento[]> GetAllEventos(){

            IQueryable<Evento> query = _context.Eventos;
            query = query.AsNoTracking().OrderBy(x => x.DataEvento);
            return await query.ToArrayAsync();

        }
    }
}