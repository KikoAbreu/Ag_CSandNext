using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agborala.Data;
using agborala.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace agborala.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinoController : ControllerBase
    {
        
        private readonly DataContext _dataContext;


        public DestinoController(DataContext dataContext){
            _dataContext = dataContext;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destino>>> GetDestinos(){
            return await _dataContext.Agborala.ToListAsync(); 
        }

        [HttpGet("id")]
        public async Task<ActionResult<Destino>> GetdestinoById(int id){
            var destino = await _dataContext.Agborala.FindAsync(id);
            if (destino == null) 
            {
                return NotFound();
            }

            return Ok(destino);
        }


    }
}