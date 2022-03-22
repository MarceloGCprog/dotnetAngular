using System.Threading.Tasks;
using ProEventos.Model;

namespace ProEventos.DAO
{
    public interface IRepository
    {
         public Task<Evento[]> GetAllEventos();
    }
}