using System.Threading.Tasks;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.DAO
{
    public interface IRepository
    {
         public Task<Evento[]> GetAllEventos();
    }
}