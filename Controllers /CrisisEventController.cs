using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HumanitarianAPI.Data;
using HumanitarianAPI.Models;

namespace HumanitarianAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrisisEventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CrisisEventController(ApplicationDbContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CrisisEvent>>> GetEvents() => await _context.CrisisEvents.ToListAsync();

        [HttpPost]
        public async Task<ActionResult<CrisisEvent>> PostEvent(CrisisEvent crisisEvent)
        {
            _context.CrisisEvents.Add(crisisEvent);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEvents), new { id = crisisEvent.Id }, crisisEvent);
        }
    }
}
