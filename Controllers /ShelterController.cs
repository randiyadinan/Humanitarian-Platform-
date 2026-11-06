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
    public class ShelterController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShelterController(ApplicationDbContext context)
        {
            _context = context;
        }

        // පද්ධතියේ තියෙන සියලුම කඳවුරු වල විස්තර ලබාගැනීම (GET)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shelter>>> GetShelters()
        {
            return await _context.Shelters.ToListAsync();
        }

        // අලුත් කඳවුරක් පද්ධතියට ඇතුළත් කිරීම (POST)
        [HttpPost]
        public async Task<ActionResult<Shelter>> CreateShelter([FromBody] Shelter newShelter)
        {
            _context.Shelters.Add(newShelter);
            await _context.SaveChangesAsync();
            return Ok(newShelter);
        }
    }
}
