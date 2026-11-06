using Microsoft.EntityFrameworkCore;
using HumanitarianAPI.Models;

namespace HumanitarianAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AssistanceRequest> AssistanceRequests { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Resource> Resources { get; set; } // සම්පත් සඳහා අලුත් Table එක
    }
}
