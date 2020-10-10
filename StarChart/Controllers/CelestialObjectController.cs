using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;
using StarChart.Models;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var celestialObject = _context.CelestialObjects.FirstOrDefault(c => c.Id == id);
            if(celestialObject == null)
            {
                return NotFound();
            }
            else
            {
                CelestialObject co = new CelestialObject();
                co.Satellites = celestialObject.Satellites;

                return Ok(celestialObject);
            }
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var celestialObject = _context.CelestialObjects.FirstOrDefault(c => c.Name == name);
            if (celestialObject == null)
            {
                return NotFound();
            }
            else
            {
                CelestialObject co = new CelestialObject();
                co.Satellites = celestialObject.Satellites;

                return Ok(celestialObject);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var celestialObjects = _context.CelestialObjects;

            foreach(var c in celestialObjects)
            {

            }
            CelestialObject co = new CelestialObject();
            //co.Satellites = celestialObject.Satellites;

            return Ok(co);

        }
    }
}
