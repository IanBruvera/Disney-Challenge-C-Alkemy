using Disney_Proyect_Akemy.Context;
using Disney_Proyect_Akemy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Disney_Proyect_Akemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Content : ControllerBase
    {
        private  readonly PersonajesDataBaseContext _context;
       
        private readonly ILogger<Content> _logger;
        private SqlConnection conexion;
        private SqlCommand mySqlCommand;
        private SqlDataReader mySqlDataReader;
        private Context.PersonajesDataBaseContext _db;


        public Content(ILogger<Content> logger, Context.PersonajesDataBaseContext db)
        {
            _logger = logger;
            _db = db;
        }
        
        


       
        [HttpGet("Name")]
        public async Task <ActionResult<Personajes>> GetPersonajesItems(string Name, Personajes personajes)
        {
            var personajeId = await _context.Personajes.FindAsync(Name);
            return personajes;
        }

       
       

       
    }
}
