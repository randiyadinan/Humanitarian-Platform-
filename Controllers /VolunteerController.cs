using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HumanitarianAPI.Models;
using HumanitarianAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumanitarianAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VolunteerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // පද්ධතියේ තියෙන සියලුම ස්වේච්ඡා සේවකයන්ගේ විස්තර ලබාගැනීම (GET)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Volunteer>>> GetVolunteers()
        {
            return await _context.Volunteers.ToListAsync();
        }

        // අලුත් ස්වේච්ඡා සේවකයෙක් පද්ධතියට ඇතුළත් කිරීම (POST)
        [HttpPost]
        public async Task<ActionResult<Volunteer>> CreateVolunteer([FromBody] Volunteer newVolunteer)
        {
            _context.Volunteers.Add(newVolunteer);
            await _context.SaveChangesAsync();
            return Ok(newVolunteer);
        }
    }
}
