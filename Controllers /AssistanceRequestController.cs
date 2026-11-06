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
    public class AssistanceRequestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Database එක Controller එකට සම්බන්ධ කිරීම
        public AssistanceRequestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Database එකේ තියෙන සියලුම ඉල්ලීම් ලබාගන්නා Endpoint එක (GET)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssistanceRequest>>> GetRequests()
        {
            return await _context.AssistanceRequests.ToListAsync();
        }

        // අලුත් ඉල්ලීමක් Database එකට ඇතුළත් කරන Endpoint එක (POST)
        [HttpPost]
        public async Task<ActionResult<AssistanceRequest>> CreateRequest([FromBody] AssistanceRequest newRequest)
        {
            _context.AssistanceRequests.Add(newRequest);
            await _context.SaveChangesAsync(); // දත්ත ස්ථිරවම Database එකේ Save කිරීම
            
            return Ok(newRequest);
        }
    }
}
