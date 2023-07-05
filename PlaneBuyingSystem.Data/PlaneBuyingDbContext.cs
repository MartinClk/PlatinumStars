
namespace PlatinumStars.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using PlaneBuyingSystem.Data.Models;
    using System.Reflection;
    public class PlaneBuyingDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public PlaneBuyingDbContext(DbContextOptions<PlaneBuyingDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Plane> Planes { get; set; } = null!;

        public DbSet<Agent> Agents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(PlaneBuyingDbContext)) ??
                                      Assembly.GetExecutingAssembly();
             builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }

    }
}