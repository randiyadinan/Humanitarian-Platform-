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
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CrisisEvent> CrisisEvents { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<AIRecommendation> AIRecommendations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
