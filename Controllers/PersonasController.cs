using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using ApiPersona.Models;

namespace ApiPersona.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly ILogger<PersonasController> _logger;
        private readonly PersonaContext _context;

        public PersonasController(ILogger<PersonasController> logger, PersonaContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return _context.Personas;
        }
    }
}

