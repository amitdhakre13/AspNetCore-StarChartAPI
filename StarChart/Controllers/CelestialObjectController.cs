using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }
    }
}
