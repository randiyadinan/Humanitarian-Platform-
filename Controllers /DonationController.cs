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
    public class DonationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DonationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donation>>> GetDonations()
        {
            return await _context.Donations.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Donation>> CreateDonation([FromBody] Donation donation)
        {
            _context.Donations.Add(donation);
            await _context.SaveChangesAsync();
            return Ok(donation);
        }
    }
}
