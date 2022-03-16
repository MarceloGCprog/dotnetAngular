using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.DAO;
using ProEventos.Model;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly IRepository _repo;

        public EventosController(IRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetEventos(){

            try{

                var result = await _repo.GetAllEventos();

                if(result != null){
                    return Ok(result);
                }
                else return BadRequest(null);
            }
            catch(Exception ex){
                return BadRequest($"Erro {ex.Message}");
            }
        }
        
    }
}
