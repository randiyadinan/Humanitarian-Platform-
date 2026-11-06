using Microsoft.EntityFrameworkCore;
using HumanitarianAPI.Models;

namespace HumanitarianAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AssistanceRequest> AssistanceRequests { get; set; }
        
        // Shelter දත්ත සඳහා අලුත් Table එකක් හැදීම
        public DbSet<Shelter> Shelters { get; set; } 
    }
}
