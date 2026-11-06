using Microsoft.EntityFrameworkCore;
using HumanitarianAPI.Models;

namespace HumanitarianAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

       
        public DbSet<AssistanceRequest> AssistanceRequests { get; set; }
    }
}
